using System;
using System.Collections.Generic;
using System.Text;

namespace MSMClientAPIService.Mapping.Models
{
    public class SNMPHistoryResponse
    {
        public int EventType { get; set; }

        public DateTime ReceiveTime { get; set; }

        public string AlarmDescription { get; set; }

        public int Value { get; set; }

        public string SiteName { get; set; }

        public string ParentSiteName { get; set; }

        public int? SitePriority { get; set; }

        public bool OnOffStatus { get; set; }

        public int RepeatCount { get; set; }

        public string Status { get; set; }
    }
}
