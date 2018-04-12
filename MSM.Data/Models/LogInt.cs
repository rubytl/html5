using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class LogInt
    {
        public int SiteId { get; set; }
        public int ProtocolId { get; set; }
        public int? Value { get; set; }
        public DateTime TimeStamp { get; set; }

        public Site Site { get; set; }
    }
}
