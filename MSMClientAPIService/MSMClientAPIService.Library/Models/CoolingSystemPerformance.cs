using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class CoolingSystemPerformance
    {
        public int SiteId { get; set; }
        public int? EcbrunTime { get; set; }
        public int? EcbrunTimeTarget { get; set; }
        public byte? EcbrunTimeStatus { get; set; }
        public int? AirConRunTime { get; set; }
        public int? AirConRunTimeTarget { get; set; }
        public byte? AirConRunTimeStatus { get; set; }
        public int? InOutTempDiff { get; set; }
        public int? InOutTempDiffTarget { get; set; }
        public byte? InOutTempDiffStatus { get; set; }
        public DateTime? StatusTimeStamp { get; set; }
        public byte? Upflag { get; set; }

        public Site Site { get; set; }
    }
}
