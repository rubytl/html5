using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class GeneratorPerformance
    {
        public int SiteId { get; set; }
        public byte? TankNmber { get; set; }
        public int? RunHourAvg { get; set; }
        public int? GenEnergyAvg { get; set; }
        public int? GenFuelConsumptionAvg { get; set; }
        public int? GenEfficiencyAvg { get; set; }
        public int? GenRunHourTarget { get; set; }
        public int? GenEfficiencyTarget { get; set; }
        public byte? RunHoursStatus { get; set; }
        public byte? FuelEfficiencyStatus { get; set; }
        public int? Tank1TotalVolume { get; set; }
        public int? Tank1MinorLow { get; set; }
        public int? Tank1MajorLow { get; set; }
        public int? Tank1Remaining { get; set; }
        public byte? Tank1RemainingStatus { get; set; }
        public DateTime? ConfigTimeStamp { get; set; }
        public DateTime? StatusTimeStamp { get; set; }
        public byte? Upflag { get; set; }

        public Site Site { get; set; }
    }
}
