using System;
using System.Collections.Generic;

namespace MSM.Data.Models
{
    public partial class RestrictedGroupConfig
    {
        public Guid RestrictedGroupId { get; set; }
        public int SiteId { get; set; }

        public RestrictedGroup RestrictedGroup { get; set; }
        public Site Site { get; set; }
    }
}
