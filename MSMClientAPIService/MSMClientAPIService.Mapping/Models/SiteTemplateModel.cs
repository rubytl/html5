using System;
using System.Collections.Generic;
using System.Text;

namespace MSMClientAPIService.Mapping.Models
{
    public class SiteTemplateModel
    {
        public string TemplateId { get; set; }
        public string TemplateName { get; set; }
        public bool OnGrid { get; set; }
        public bool Solar { get; set; }
        public int? SolarEnergyTarget { get; set; }
        public bool Wind { get; set; }
        public int? WindEnergyTarget { get; set; }
        public int? RenewEnergyTarget { get; set; }
        public bool Generator { get; set; }
        public int? GenRunHourTarget { get; set; }
        public int? GenEfficiencyTarget { get; set; }
        public byte? AveLoadResetInterval { get; set; }
        public string PeakLoadRange { get; set; }
        public string AverageLoadRange { get; set; }
        public bool Battery { get; set; }
        public int? BatteryDischargeAh { get; set; }
        public string Monitor1 { get; set; }
        public string Monitor2 { get; set; }
        public string Monitor3 { get; set; }
        public string Monitor4 { get; set; }
        public string Monitor5 { get; set; }
        public string Monitor6 { get; set; }
        public bool MainsMonitor { get; set; }
        public bool MainsMonitorOnSystem { get; set; }
        public int? MainsFractionTarget { get; set; }
        public int? MainsAvlTarget { get; set; }
        public int? OverChargetTarget { get; set; }
        public int? ConnQualityTarget { get; set; }
        public int? ConnLossTarget { get; set; }
        public int? EcbrunTimeTarget { get; set; }
        public int? AirConRunTimeTarget { get; set; }
        public bool IoUnitWithEcbonSystem { get; set; }
        public int? InstalledBatteryBackupTarget { get; set; }
    }
}
