using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSM.Data.Models;
using MSMClientAPIService.Mapping.Models;

namespace MSMClientAPIService.Mapping
{
    /// <summary>
    /// SiteMappingProfile
    /// </summary>
    public static class SiteMappingProfile
    {
        /// <summary>
        /// Maps the site model to site.
        /// </summary>
        /// <param name="site">The site.</param>
        /// <returns></returns>
        public static Site MapSiteModelToSite(SiteModel site)
        {
            return new Site()
            {
                Id = site.Id,
                ParentId = site.ParentId,
                Description = site.Description,
                IsToplevel = site.IsToplevel,
                Status = site.Status,
                Address = site.Address,
                Latitude = site.Latitude,
                Longitude = site.Longitude,
                SystemType = site.SystemType,
                TemplateId = site.TemplateId,
                SitePriority = site.SitePriority,
                JsonService = site.JsonService,
                JsonPassword = site.JsonPassword,
                Ssl = site.Ssl,
                JsonUserName = site.JsonUserName,
                NotificationEnabled = site.NotificationEnabled,
                NotificationName = site.NotificationName,
                SharedCategories = site.SharedCategories,
                ControllerType = site.ControllerType,
                SnmpTemplateId = site.SnmpTemplateId,
                SnmpDataTemplateId = site.SnmpDataTemplateId,
                SecurityProtocol = site.SecurityProtocol
            };
        }

        /// <summary>
        /// Maps the site to site model.
        /// </summary>
        /// <param name="site">The site.</param>
        /// <returns></returns>
        public static SiteModel MapSiteToSiteModel(Site site)
        {
            return new SiteModel()
            {
                Id = site.Id,
                ParentId = site.ParentId,
                Description = site.Description,
                IsToplevel = site.IsToplevel,
                Status = site.Status,
                Address = site.Address,
                Latitude = site.Latitude,
                Longitude = site.Longitude,
                SystemType = site.SystemType,
                TemplateId = site.TemplateId,
                SitePriority = site.SitePriority,
                JsonService = site.JsonService,
                JsonPassword = site.JsonPassword,
                Ssl = site.Ssl,
                JsonUserName = site.JsonUserName,
                NotificationEnabled = site.NotificationEnabled,
                NotificationName = site.NotificationName,
                SharedCategories = site.SharedCategories,
                ControllerType = site.ControllerType,
                SnmpTemplateId = site.SnmpTemplateId,
                SnmpDataTemplateId = site.SnmpDataTemplateId,
                SecurityProtocol = site.SecurityProtocol
            };
        }
    }
}
