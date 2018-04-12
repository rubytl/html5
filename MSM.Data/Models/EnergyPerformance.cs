using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class EnergyPerformance
    {
        public int SiteId { get; set; }
        public int? AcenergyTotal { get; set; }
        public int? RectifierEnergyTotal { get; set; }
        public int? SolarEnergyTotal { get; set; }
        public int? WindEnergyTotal { get; set; }
        public int? GenEnergyTotal { get; set; }
        public int? AcmonitorEnergyTotal { get; set; }
        public int? MainsFractionTotal { get; set; }
        public int? TotalEnergy { get; set; }
        public int? SolarEnergyTarget { get; set; }
        public int? WindEnergyTarget { get; set; }
        public int? MainsFractionTarget { get; set; }
        public int? MainsAvlTarget { get; set; }
        public byte? SolarEnergyStatus { get; set; }
        public byte? WindEnergyStatus { get; set; }
        public byte? MainsFractionStatus { get; set; }
        public DateTime? WeeklyTimeStamp { get; set; }
        public int? MainsOutageTotal { get; set; }
        public byte? MainsAvailableStatus { get; set; }
        public DateTime? DailyTimeStamp { get; set; }
        public byte? Upflag { get; set; }

        public Site Site { get; set; }
    }
}
