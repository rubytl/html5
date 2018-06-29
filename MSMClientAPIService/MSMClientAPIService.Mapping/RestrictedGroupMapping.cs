﻿using System;
using System.Collections.Generic;
using System.Text;
using MSM.Data.Models;
using MSMClientAPIService.Mapping.Models;

namespace MSMClientAPIService.Mapping
{
    public class RestrictedGroupMapping
    {
        public static RestrictedGroupConfig MapModelToGroupConfiguration(RestrictedGroupConfigurationModel model)
        {
            return new RestrictedGroupConfig()
            {
                RestrictedGroupId = model.RestrictedGroupId,
                SiteId = model.SiteId
            };
        }
    }
}
