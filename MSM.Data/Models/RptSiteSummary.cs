using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class RptSiteSummary
    {
        public int SiteId { get; set; }
        public string SiteDescription { get; set; }
        public int? ParentId { get; set; }
        public string ParentDescription { get; set; }
        public int? AlarmPresentRanking { get; set; }
        public int? AlarmHistoryRanking { get; set; }
        public DateTime? ActiveAlarm { get; set; }
        public DateTime? HistoricalAlarm { get; set; }
        public byte? SolarEnergyStatus { get; set; }
        public byte? WindEnergyStatus { get; set; }
        public byte? MainsFractionStatus { get; set; }
        public byte? MainsAvailableStatus { get; set; }
        public int? RemainingLife { get; set; }
        public byte? LifeTimeStatus { get; set; }
        public byte? TimeLeftStatus { get; set; }
        public byte? BattTempStatus { get; set; }
        public byte? UpTimeUpstatus { get; set; }
        public byte? LossNumUpstatus { get; set; }
    }
}
