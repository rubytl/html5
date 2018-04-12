using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class ENexusConfiguration
    {
        public ENexusConfiguration()
        {
            ENexusConfigPoints = new HashSet<ENexusConfigPoints>();
            SiteEventLog = new HashSet<SiteEventLog>();
            SiteEventQueue = new HashSet<SiteEventQueue>();
        }

        public short ENexusConfigId { get; set; }
        public string Description { get; set; }
        public bool? Enabled { get; set; }

        public ICollection<ENexusConfigPoints> ENexusConfigPoints { get; set; }
        public ICollection<SiteEventLog> SiteEventLog { get; set; }
        public ICollection<SiteEventQueue> SiteEventQueue { get; set; }
    }
}
