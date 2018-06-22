using System;
using System.Collections.Generic;
using System.Text;
using MSM.Data.Models;
using MSMClientAPIService.Mapping.Models;

namespace MSMClientAPIService.Mapping
{
    public static class UserLoginConfigurationMapping
    {
        public static UserLoginConfiguration MapModelToUserLoginConfiguration(UserLoginConfigurationModel model)
        {
            return new UserLoginConfiguration()
            {
                UserName = model.UserName,
                RoleName = model.RoleName,
                RestrictedGroupId = model.RestrictedGroupID
            };
        }
    }
}
