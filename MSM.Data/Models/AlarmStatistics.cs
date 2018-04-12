using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class AlarmStatistics
    {
        public int SiteId { get; set; }
        public int? SiteStatus { get; set; }
        public DateTime? MonitoredSince { get; set; }
        public DateTime? PresentAlarmDate { get; set; }
        public DateTime? PresentWarningDate { get; set; }
        public DateTime? PresentOfflineDate { get; set; }
        public string TotalAlarmHours { get; set; }
        public string TotalWarningHours { get; set; }
        public string TotalOffLineHours { get; set; }
        public int? AlarmRatio { get; set; }
        public int? WarningRatio { get; set; }
        public int? OffLineRatio { get; set; }
        public int? AlarmPresentRanking { get; set; }
        public int? WarningPresentRanking { get; set; }
        public int? OffLinePresentRanking { get; set; }
        public int? AlarmHistoryRanking { get; set; }
        public int? WarningHistoryRanking { get; set; }
        public int? OffLineHistoryRanking { get; set; }
    }
}
