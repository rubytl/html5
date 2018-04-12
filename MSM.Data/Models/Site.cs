using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class Site
    {
        public Site()
        {
            ENexusDataLog = new HashSet<ENexusDataLog>();
            InverseParent = new HashSet<Site>();
            LogInt = new HashSet<LogInt>();
            LogString = new HashSet<LogString>();
            LogVarChar = new HashSet<LogVarChar>();
            OccasionalNotification = new HashSet<OccasionalNotification>();
            RestrictedGroupConfig = new HashSet<RestrictedGroupConfig>();
            SiteEventLog = new HashSet<SiteEventLog>();
            SiteEventQueue = new HashSet<SiteEventQueue>();
            SiteInventory = new HashSet<SiteInventory>();
            SiteNotification = new HashSet<SiteNotification>();
            SiteWebCamera = new HashSet<SiteWebCamera>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Description { get; set; }
        public bool? IsToplevel { get; set; }
        public int? Status { get; set; }
        public string Address { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int? SystemType { get; set; }
        public string TemplateId { get; set; }
        public int? SitePriority { get; set; }
        public int JsonService { get; set; }
        public bool Ssl { get; set; }
        public string JsonUserName { get; set; }
        public string JsonPassword { get; set; }
        public bool NotificationEnabled { get; set; }
        public string NotificationName { get; set; }
        public int? SharedCategories { get; set; }
        public int ControllerType { get; set; }
        public int? SnmpTemplateId { get; set; }
        public string SnmpDataTemplateId { get; set; }
        public int? SecurityProtocol { get; set; }

        public Site Parent { get; set; }
        public SnmpconfigTemplate SnmpTemplate { get; set; }
        public SiteTemplate Template { get; set; }
        public BatteryMaintenance BatteryMaintenance { get; set; }
        public BatteryPerformance BatteryPerformance { get; set; }
        public CoolingSystemPerformance CoolingSystemPerformance { get; set; }
        public EnergyCostPerformance EnergyCostPerformance { get; set; }
        public EnergyPerformance EnergyPerformance { get; set; }
        public GeneratorPerformance GeneratorPerformance { get; set; }
        public SiteConnectivityQuality SiteConnectivityQuality { get; set; }
        public SiteExtention SiteExtention { get; set; }
        public ICollection<ENexusDataLog> ENexusDataLog { get; set; }
        public ICollection<Site> InverseParent { get; set; }
        public ICollection<LogInt> LogInt { get; set; }
        public ICollection<LogString> LogString { get; set; }
        public ICollection<LogVarChar> LogVarChar { get; set; }
        public ICollection<OccasionalNotification> OccasionalNotification { get; set; }
        public ICollection<RestrictedGroupConfig> RestrictedGroupConfig { get; set; }
        public ICollection<SiteEventLog> SiteEventLog { get; set; }
        public ICollection<SiteEventQueue> SiteEventQueue { get; set; }
        public ICollection<SiteInventory> SiteInventory { get; set; }
        public ICollection<SiteNotification> SiteNotification { get; set; }
        public ICollection<SiteWebCamera> SiteWebCamera { get; set; }
    }
}
