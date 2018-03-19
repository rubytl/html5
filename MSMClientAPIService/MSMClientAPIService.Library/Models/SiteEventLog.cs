using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class SiteEventLog
    {
        public long Id { get; set; }
        public Guid SessionId { get; set; }
        public int SiteId { get; set; }
        public int EventType { get; set; }
        public DateTime QueueTime { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public DateTime ProcessTime { get; set; }
        public Guid? ReportDocId { get; set; }
        public DateTime? ReportTime { get; set; }
        public Guid? ReferenceDocId { get; set; }
        public short? ENexusConfigId { get; set; }
        public int? NumDatapoints { get; set; }
        public int? NumFails { get; set; }
        public byte Status { get; set; }
        public string Result { get; set; }

        public ENexusConfiguration ENexusConfig { get; set; }
        public Site Site { get; set; }
    }
}
