using System;
using System.Collections.Generic;
using System.Text;

namespace ebaun.Models
{
    public class Notification
    {
        public string body { get; set; }
        public string title { get; set; }
    }

    public class Message
    {
        public string topic { get; set; }
        public Notification notification { get; set; }
    }

    public class PushMessage
    {
        public Message message { get; set; }
    }
}
