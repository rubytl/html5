using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class BatteryPerformance
    {
        public int SiteId { get; set; }
        public int? LifeTimeMajorHigh { get; set; }
        public int? LifeTimeMinorHigh { get; set; }
        public int? LifeTimeValue { get; set; }
        public byte? LifeTimeStatus { get; set; }
        public byte? LifeTimeValState { get; set; }
        public int? RemainingLifeTime { get; set; }
        public int? TimeLeftMajorLow { get; set; }
        public int? TimeLeftMinorLow { get; set; }
        public int? TimeLeftValue { get; set; }
        public byte? TimeLeftStatus { get; set; }
        public byte? TimeLeftValState { get; set; }
        public int? BattTempAve { get; set; }
        public int? BattTempMinorHigh { get; set; }
        public byte? BattTempStatus { get; set; }
        public int? AhCharged { get; set; }
        public int? AhDisCharged { get; set; }
        public byte? OverChargedStatus { get; set; }
        public int? OverChargedTarget { get; set; }
        public byte? SymmetryStatus { get; set; }
        public DateTime? ConfigTimeStamp { get; set; }
        public DateTime? StatusTimeStamp { get; set; }
        public byte? Upflag { get; set; }

        public Site Site { get; set; }
    }
}
