using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class SiteConnectivityQuality
    {
        public int SiteId { get; set; }
        public DateTime? StartDate { get; set; }
        public int? UpTimeTotal { get; set; }
        public int? UpTimeRate { get; set; }
        public short? UpTimeToday { get; set; }
        public string UpTimeDailyLog { get; set; }
        public int? ConnQualityTarget { get; set; }
        public byte? UpTimeUpstatus { get; set; }
        public DateTime? UpTimeStamp { get; set; }
        public int? LossNumTotal { get; set; }
        public short? LossNumToday { get; set; }
        public string LossNumDailyLog { get; set; }
        public int? ConnLossTarget { get; set; }
        public byte? LossNumUpstatus { get; set; }
        public DateTime? LossTimeStamp { get; set; }
        public byte? Upflag { get; set; }
        public DateTime? LogTimeStamp { get; set; }

        public Site Site { get; set; }
    }
}
