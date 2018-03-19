using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class RestrictedGroup
    {
        public RestrictedGroup()
        {
            RestrictedGroupConfig = new HashSet<RestrictedGroupConfig>();
            UserLoginConfiguration = new HashSet<UserLoginConfiguration>();
        }

        public Guid RestrictedGroupId { get; set; }
        public string RestrictedGroupName { get; set; }

        public ICollection<RestrictedGroupConfig> RestrictedGroupConfig { get; set; }
        public ICollection<UserLoginConfiguration> UserLoginConfiguration { get; set; }
    }
}
