using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class Msmdictionary
    {
        public Msmdictionary()
        {
            SiteTemplateAverageLoadRangeNavigation = new HashSet<SiteTemplate>();
            SiteTemplateBatteryConfigNavigation = new HashSet<SiteTemplate>();
            SiteTemplateBatteryTechnologyNavigation = new HashSet<SiteTemplate>();
            SiteTemplateControllerTypeNavigation = new HashSet<SiteTemplate>();
            SiteTemplateCoolingNavigation = new HashSet<SiteTemplate>();
            SiteTemplateGeneratorConfigNavigation = new HashSet<SiteTemplate>();
            SiteTemplateLoadTypeNavigation = new HashSet<SiteTemplate>();
            SiteTemplateMonitor1Navigation = new HashSet<SiteTemplate>();
            SiteTemplateMonitor2Navigation = new HashSet<SiteTemplate>();
            SiteTemplateMonitor3Navigation = new HashSet<SiteTemplate>();
            SiteTemplateMonitor4Navigation = new HashSet<SiteTemplate>();
            SiteTemplateMonitor5Navigation = new HashSet<SiteTemplate>();
            SiteTemplateMonitor6Navigation = new HashSet<SiteTemplate>();
            SiteTemplatePeakLoadRangeNavigation = new HashSet<SiteTemplate>();
        }

        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public int? ExtVal { get; set; }

        public Msmdictionary Item { get; set; }
        public Msmdictionary InverseItem { get; set; }
        public ICollection<SiteTemplate> SiteTemplateAverageLoadRangeNavigation { get; set; }
        public ICollection<SiteTemplate> SiteTemplateBatteryConfigNavigation { get; set; }
        public ICollection<SiteTemplate> SiteTemplateBatteryTechnologyNavigation { get; set; }
        public ICollection<SiteTemplate> SiteTemplateControllerTypeNavigation { get; set; }
        public ICollection<SiteTemplate> SiteTemplateCoolingNavigation { get; set; }
        public ICollection<SiteTemplate> SiteTemplateGeneratorConfigNavigation { get; set; }
        public ICollection<SiteTemplate> SiteTemplateLoadTypeNavigation { get; set; }
        public ICollection<SiteTemplate> SiteTemplateMonitor1Navigation { get; set; }
        public ICollection<SiteTemplate> SiteTemplateMonitor2Navigation { get; set; }
        public ICollection<SiteTemplate> SiteTemplateMonitor3Navigation { get; set; }
        public ICollection<SiteTemplate> SiteTemplateMonitor4Navigation { get; set; }
        public ICollection<SiteTemplate> SiteTemplateMonitor5Navigation { get; set; }
        public ICollection<SiteTemplate> SiteTemplateMonitor6Navigation { get; set; }
        public ICollection<SiteTemplate> SiteTemplatePeakLoadRangeNavigation { get; set; }
    }
}
