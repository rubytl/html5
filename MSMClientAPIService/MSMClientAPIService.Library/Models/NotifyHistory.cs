using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class NotifyHistory
    {
        public int SiteId { get; set; }
        public string Description { get; set; }
        public int NotificationId { get; set; }
        public int ActionType { get; set; }
        public int TriggerType { get; set; }
        public string AllReceiver { get; set; }
        public int AlarmId { get; set; }
        public int AlarmSiteId { get; set; }
        public string SiteDescription { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Ipaddress { get; set; }
        public string AlarmDescription { get; set; }
        public int Value { get; set; }
        public int EventType { get; set; }
        public DateTime AlarmOnTime { get; set; }
        public DateTime? AlarmOffTime { get; set; }
        public string EmailList { get; set; }
        public DateTime? ExpectedNextNotifyTime { get; set; }
        public int DelayMinute { get; set; }
        public DateTime? MonitoredSince { get; set; }
        public int? AlarmRatio { get; set; }
        public int? WarningRatio { get; set; }
        public int? OffLineRatio { get; set; }
        public int? MajorRankingPresent { get; set; }
        public int? MajorRankingHistorical { get; set; }
        public byte? ReportFormat { get; set; }
    }
}
