using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class RptUnderPerforming
    {
        public int SiteId { get; set; }
        public string SiteDescription { get; set; }
        public int? AcinputRate { get; set; }
        public int? GeneratorRate { get; set; }
        public int? SolarRate { get; set; }
        public int? WindRate { get; set; }
        public byte? SolarEnergyStatus { get; set; }
        public byte? WindEnergyStatus { get; set; }
        public int? MainsMonitorDcrate { get; set; }
        public int? MainsFractionRate { get; set; }
        public byte? MainsFractionStatus { get; set; }
        public int? MainsAvailableRate { get; set; }
        public byte? MainsAvailableStatus { get; set; }
        public int? RemainingLife { get; set; }
        public int? Eofrate { get; set; }
        public byte? LifeTimeStatus { get; set; }
        public int? TimeLeftMinutes { get; set; }
        public byte? TimeLeftStatus { get; set; }
        public int? BattTempAve { get; set; }
        public byte? BattTempStatus { get; set; }
        public int? OverCharged { get; set; }
        public byte? OverChargedStatus { get; set; }
        public byte? SymmetryStatus { get; set; }
        public int? RunHourAvg { get; set; }
        public byte? RunHoursStatus { get; set; }
        public int? GenEfficiencyAvg { get; set; }
        public byte? FuelEfficiencyStatus { get; set; }
        public int? Tank1Remaining { get; set; }
        public byte? Tank1RemainingStatus { get; set; }
        public int? UpTimeRate { get; set; }
        public byte? UpTimeUpstatus { get; set; }
        public int? LossNumTotal { get; set; }
        public byte? LossNumUpstatus { get; set; }
    }
}
