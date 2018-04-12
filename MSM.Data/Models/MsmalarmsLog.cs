using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class MsmalarmsLog
    {
        public Guid AlarmIdentifier { get; set; }
        public int AlarmCatalogId { get; set; }
        public int? AlarmStatusId { get; set; }
        public string SenderIdentifier { get; set; }
        public int? SiteId { get; set; }
        public string Ipaddress { get; set; }
        public string SiteDescription { get; set; }
        public string AlarmDescription { get; set; }
        public decimal Value { get; set; }
        public int EventType { get; set; }
        public decimal? MajorAlarmLevel { get; set; }
        public decimal? MinorAlarmLevel { get; set; }
        public DateTime AlarmOnTime { get; set; }
        public DateTime? AlarmOffTime { get; set; }
        public string OriginalOid { get; set; }
    }
}
