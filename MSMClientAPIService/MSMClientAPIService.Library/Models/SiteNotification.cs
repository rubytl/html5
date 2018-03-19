using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class SiteNotification
    {
        public int SiteId { get; set; }
        public bool InheritedNotification { get; set; }
        public int NotificationId { get; set; }
        public bool InheritedReceiver { get; set; }
        public string DefaultReceiver { get; set; }
        public bool Enabled { get; set; }
        public DateTime? ExpectedNextNotifyTime { get; set; }

        public Notifications Notification { get; set; }
        public Site Site { get; set; }
    }
}
