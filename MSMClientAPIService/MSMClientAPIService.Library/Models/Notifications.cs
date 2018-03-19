using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class Notifications
    {
        public Notifications()
        {
            SiteNotification = new HashSet<SiteNotification>();
        }

        public int NotificationId { get; set; }
        public string Description { get; set; }
        public int ActionType { get; set; }
        public int TriggerType { get; set; }
        public byte ReportType { get; set; }
        public bool UseReceiver { get; set; }
        public string Receiver { get; set; }
        public int DelayMinute { get; set; }
        public bool? Enabled { get; set; }
        public bool IsGlobal { get; set; }
        public DateTime? ExpectedNextNotifyTime { get; set; }
        public byte? ReportFormat { get; set; }

        public ICollection<SiteNotification> SiteNotification { get; set; }
    }
}
