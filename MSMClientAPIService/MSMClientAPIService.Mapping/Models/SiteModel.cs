using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSMClientAPIService.Mapping.Models
{
    public class SiteModelBase
    {
        public int Id { get; set; }

        public string Description { get; set; }
        public int? ParentId { get; set; }

    }

    public class SiteModel : SiteModelBase
    {
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
        public int? SnmpDataTemplateId { get; set; }
        public int? SecurityProtocol { get; set; }
    }
}
