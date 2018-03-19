using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class RptNotifyNow
    {
        public int Idx { get; set; }
        public int SiteId { get; set; }
        public int NotificationId { get; set; }
        public string SiteDescription { get; set; }
        public string NotificationDescription { get; set; }
        public int TriggerType { get; set; }
        public int ReportType { get; set; }
        public int ActionType { get; set; }
        public string AllReceiver { get; set; }
        public string EmailList { get; set; }
        public DateTime? ExpectedNextNotifyTime { get; set; }
        public int? DelayMinute { get; set; }
        public string Ipaddress { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool IsGlobal { get; set; }
        public bool IsOccasionalRpt { get; set; }
        public string DataLogType { get; set; }
        public string Sender { get; set; }
        public byte? ReportFormat { get; set; }
    }
}
