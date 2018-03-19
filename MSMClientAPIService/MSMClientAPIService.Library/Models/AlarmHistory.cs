using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class AlarmHistory
    {
        public int AlarmId { get; set; }
        public string TrapOid { get; set; }
        public int SiteId { get; set; }
        public string SiteDescription { get; set; }
        public string AlarmDescription { get; set; }
        public int Value { get; set; }
        public int EventType { get; set; }
        public DateTime AlarmOnTime { get; set; }
        public int RepeatCount { get; set; }
        public DateTime? AlarmOffTime { get; set; }
        public bool NotifiedStatus { get; set; }
        public string LastNotifiedTo { get; set; }
        public DateTime? LastNotifiedTime { get; set; }
    }
}
