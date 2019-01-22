/*
 * Copyright (c) 2013 Google Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except
 * in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software distributed under the
 * License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Google.Apis.Json;
using Google.Apis.Mirror.v1;
using Google.Apis.Mirror.v1.Data;
using Google.Apis.Services;
using MirrorQuickstart.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using System.IO;
using System.Drawing;
using MirrorQuickstart.com.ocrwebservice.www;

namespace MirrorQuickstart.Controllers
{
    public class NotifyController : Controller
    {
        //
        // POST: /notify

        [HttpPost]
        public ActionResult Notify()
        {
            Notification notification =
                new NewtonsoftJsonSerializer().Deserialize<Notification>(Request.InputStream);
            String userId = notification.UserToken;
            MirrorService service = new MirrorService(new BaseClientService.Initializer()
            {
                Authenticator = Utils.GetAuthenticatorFromState(Utils.GetStoredCredentials(userId))
            });

            if (notification.Collection == "locations")
            {
                HandleLocationsNotification(notification, service);
            }
            else if (notification.Collection == "timeline")
            {
                HandleTimelineNotification(notification, service);
            }

            return new HttpStatusCodeResult((int)HttpStatusCode.OK);
        }

        /// <summary>
        /// Inserts a timeline item with the latest location information.
        /// </summary>
        /// <param name="notification">Notification payload.</param>
        /// <param name="service">Authorized Mirror service.</param>
        private void HandleLocationsNotification(Notification notification, MirrorService service)
        {
            Location location = service.Locations.Get(notification.ItemId).Fetch();
            TimelineItem item = new TimelineItem()
            {
                Text = "New location is " + location.Latitude + ", " + location.Longitude,
                Location = location,
                MenuItems = new List<MenuItem>() { new MenuItem() { Action = "NAVIGATE" } },
                Notification = new NotificationConfig() { Level = "DEFAULT" }
            };

            service.Timeline.Insert(item).Fetch();
        }

        /// <summary>
        /// Process the timeline collection notification.
        /// </summary>
        /// <param name="notification">Notification payload.</param>
        /// <param name="service">Authorized Mirror service.</param>
        private void HandleTimelineNotification(Notification notification, MirrorService service)
        {
            foreach (UserAction action in notification.UserActions)
            {
                if (action.Type == "SHARE")
                {
                    TimelineItem item = service.Timeline.Get(notification.ItemId).Fetch();

                    //Attachment attachment = service.Timeline.Attachments.Get("6218558593826816", "AMIfv97hy2SzahEyAvQJY3f7AXMBK85i4sK9DZCd0xILTgCLjG810uZ_OZQfx0WudpqrtvYrcA9541-xM1Uy7BM3blRbP-nVJrFZz0EvI5QrEji0YabyoGXcu66pq1T2Mea4ypB3HBbgsfPcnABrdE1Lt7okjMjIu6i00l__WGQlO_iG-o7fF2w").Fetch();
                    Attachment attachment = service.Timeline.Attachments.Get(item.Id, item.Attachments[0].Id).Fetch();
                    string gid = Guid.NewGuid().ToString();
                    string imageFile = string.Format(@"C:\Users\E567623\Desktop\Printing\TestImage-{0}.png",gid);
                    string equipmentName = string.Empty;
                    // if the remote file was found, download oit
                    using (Stream inputStream = DownloadAttachment(service, attachment))
                    {
                        using (Stream outputStream = System.IO.File.Create(imageFile))
                        {
                            byte[] buffer = new byte[4096];
                            int bytesRead;
                            do
                            {
                                bytesRead = inputStream.Read(buffer, 0, buffer.Length);
                                outputStream.Write(buffer, 0, bytesRead);
                            } while (bytesRead != 0);

                            outputStream.Close();
                        }

                        inputStream.Close();
                        equipmentName = this.GetTextFromImage(imageFile);
                    }

                    item.Text = "You have given equipment name :" + equipmentName;
                    item.Notification = new NotificationConfig() { Level = "DEFAULT" };

                    service.Timeline.Update(item, item.Id).Fetch();
                    // Only handle the first successful action.
                    break;
                }
                else
                {
                    Console.WriteLine(
                        "I don't know what to do with this notification: " + action.ToString());
                }
            }
        }

        /// <summary>
        /// Download a timeline items's attachment.
        /// </summary>
        /// <param name="service">Authorized Mirror service.</param>
        /// <param name="attachment">Attachment to download content for.</param>
        /// <returns>Attachment's content if successful, null otherwise.</returns>
        public static System.IO.Stream DownloadAttachment(
            MirrorService service, Attachment attachment)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(
                  new Uri(attachment.ContentUrl));
                service.Authenticator.ApplyAuthenticationToRequest(request);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.GetResponseStream();
                }
                else
                {
                    Console.WriteLine(
                      "An error occurred: " + response.StatusDescription);
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
                return null;
            }
        }

        private string GetTextFromImage(string path)
        {
            string imageFilePath = path;
            const string USER_NAME = "VASANTH91";
            const string LICENCE_CODE = "381CE5F0-4074-4A64-B593-A28EBD1AB968";

            var imageFileName = Path.GetFileName(imageFilePath);
            Image image = Image.FromFile(imageFilePath);
            MemoryStream ms = new MemoryStream();
            //imageStream.CopyTo(ms);
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] imageFileData = ms.ToArray();

            //Create Request 
            OCRWSInputImage inputImage = new OCRWSInputImage();
            inputImage.fileName = imageFileName;
            inputImage.fileData = imageFileData;

            OCRWSSettings ocrSettings = new OCRWSSettings();
            ocrSettings.getOCRText = true;
            var languages = new OCRWS_Language[] { OCRWS_Language.ENGLISH };
            ocrSettings.ocrLanguages = languages;

            //calling service
            var webServiceClient = new OCRWebService();
            var response = webServiceClient.OCRWebServiceRecognize(USER_NAME, LICENCE_CODE, inputImage, ocrSettings);

            var equipmentName = string.Empty;
            foreach (var textArray in response.ocrText)
            {
                foreach (var text in textArray)
                {
                    equipmentName = text;
                    break;
                }
            }

            return equipmentName;
        }

    }
}
