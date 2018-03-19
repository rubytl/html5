using System;
using System.Collections.Generic;

namespace MSMClientAPIService.Data.Models
{
    public partial class UserLoginConfiguration
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int? FilterPreference { get; set; }
        public int? MainPagePreference { get; set; }
        public string RoleName { get; set; }
        public Guid? RestrictedGroupId { get; set; }

        public RestrictedGroup RestrictedGroup { get; set; }
    }
}
