using ebaun.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ebaun.Services
{
    public class Notificator
    {
        public static async Task SendMessage(string topic, string title, string message)
        {
            await Task.Run(() =>
            {
                string serverKey = "AAAAhdrbZDo:APA91bHIodJ-w_MDBHrQqCBkjQWOs_b1Om87sx-el6TzsvjZ_nyJBsCJbzq8za84jMRJUlrGhKMfChZudIr2wobW3-45bPjw6wMZXdolNtpEAuMDgLvT7iAFw8wkRWcpjKYDQtuCr7b9";

                try
                {
                    var result = "-1";
                    var webAddr = "https://fcm.googleapis.com/fcm/send";

                    var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.Headers.Add("Authorization:key=" + serverKey);
                    httpWebRequest.Method = "POST";

                    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        PushMessage msg = new PushMessage
                        {
                            message = new Message
                            {
                                topic = topic,
                                notification = new Notification
                                {
                                    title = title,
                                    body = message
                                }
                            }
                        };
                        string json = JsonConvert.SerializeObject(msg);
                        streamWriter.Write(json);
                        streamWriter.Flush();
                    }

                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        result = streamReader.ReadToEnd();
                    }

                   // return result;
               }
                catch (Exception ex)
                {
                   //  Response.Write(ex.Message);
               }
            });
        }
    }
}
