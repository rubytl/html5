using System;
using System.Collections.Generic;
using System.Text;

namespace MSMClientAPIService.Mapping.Models
{
    public class RestrictedGroupConfigurationModel
    {
        public Guid RestrictedGroupId { get; set; }
        public int SiteId { get; set; }
    }
}
