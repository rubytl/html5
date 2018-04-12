using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class SiteEventQueue
    {
        public long QueueId { get; set; }
        public Guid SessionId { get; set; }
        public int SiteId { get; set; }
        public int EventType { get; set; }
        public byte Priority { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public byte Status { get; set; }
        public DateTime QueueTime { get; set; }
        public DateTime StatusTime { get; set; }
        public Guid? ReferenceDocId { get; set; }
        public short? ENexusConfigId { get; set; }

        public ENexusConfiguration ENexusConfig { get; set; }
        public Site Site { get; set; }
    }
}
