using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class LogVarChar
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int ProtocolId { get; set; }
        public string Value { get; set; }
        public DateTime TimeStamp { get; set; }
        public DateTime? SptimeStamp { get; set; }

        public Site Site { get; set; }
    }
}
