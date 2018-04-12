using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class SiteTemplate
    {
        public SiteTemplate()
        {
            Site = new HashSet<Site>();
        }

        public string TemplateId { get; set; }
        public string TemplateName { get; set; }
        public bool InDoor { get; set; }
        public string Cooling { get; set; }
        public bool OnGrid { get; set; }
        public decimal? GridCostTarget { get; set; }
        public string ControllerType { get; set; }
        public bool Solar { get; set; }
        public int? SolarNum { get; set; }
        public int? SolarEnergyTarget { get; set; }
        public DateTime? SolarInstallDate { get; set; }
        public decimal? SolarInstallCost { get; set; }
        public decimal? SolarCostTarget { get; set; }
        public bool Wind { get; set; }
        public int? WindNum { get; set; }
        public int? WindEnergyTarget { get; set; }
        public DateTime? WindInstallDate { get; set; }
        public DateTime? WindInstallCost { get; set; }
        public decimal? WindCostTarget { get; set; }
        public int? RenewEnergyTarget { get; set; }
        public bool Generator { get; set; }
        public int? GeneratorRating { get; set; }
        public string GeneratorBrand { get; set; }
        public string GeneratorConfig { get; set; }
        public int? GenRunHourTarget { get; set; }
        public int? GenEfficiencyTarget { get; set; }
        public decimal? GenCostTarget { get; set; }
        public string LoadType { get; set; }
        public byte? AveLoadResetInterval { get; set; }
        public string PeakLoadRange { get; set; }
        public int? PeakLoadFrom { get; set; }
        public int? PeakLoadTo { get; set; }
        public string AverageLoadRange { get; set; }
        public int? AverageLoadFrom { get; set; }
        public int? AverageLoadTo { get; set; }
        public int? LoadProfileTarget { get; set; }
        public bool Battery { get; set; }
        public int? BatterySize { get; set; }
        public string BatteryTechnology { get; set; }
        public string BatteryConfig { get; set; }
        public int? BatteryWarranty { get; set; }
        public int? BatteryDischargeAh { get; set; }
        public int? BatteryBackupTime { get; set; }
        public int? InstalledBatteryBackupTarget { get; set; }
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
        public int? InOutTempDiffTarget { get; set; }
        public bool IoUnitWithEcbonSystem { get; set; }

        public Msmdictionary AverageLoadRangeNavigation { get; set; }
        public Msmdictionary BatteryConfigNavigation { get; set; }
        public Msmdictionary BatteryTechnologyNavigation { get; set; }
        public Msmdictionary ControllerTypeNavigation { get; set; }
        public Msmdictionary CoolingNavigation { get; set; }
        public Msmdictionary GeneratorConfigNavigation { get; set; }
        public Msmdictionary LoadTypeNavigation { get; set; }
        public Msmdictionary Monitor1Navigation { get; set; }
        public Msmdictionary Monitor2Navigation { get; set; }
        public Msmdictionary Monitor3Navigation { get; set; }
        public Msmdictionary Monitor4Navigation { get; set; }
        public Msmdictionary Monitor5Navigation { get; set; }
        public Msmdictionary Monitor6Navigation { get; set; }
        public Msmdictionary PeakLoadRangeNavigation { get; set; }
        public ICollection<Site> Site { get; set; }
    }
}
