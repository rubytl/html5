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
        public static void MapSiteModelToExistingSite(SiteModel site, Site siteEntity)
        {
            siteEntity.ParentId = site.ParentId;
            siteEntity.Description = site.Description;
            siteEntity.IsToplevel = site.IsToplevel;
            siteEntity.Status = site.Status;
            siteEntity.Address = site.Address;
            siteEntity.Latitude = site.Latitude;
            siteEntity.Longitude = site.Longitude;
            siteEntity.SystemType = site.SystemType;
            siteEntity.TemplateId = site.TemplateId;
            siteEntity.SitePriority = site.SitePriority;
            siteEntity.JsonService = site.JsonService;
            siteEntity.JsonPassword = site.JsonPassword;
            siteEntity.Ssl = site.Ssl;
            siteEntity.JsonUserName = site.JsonUserName;
            siteEntity.NotificationEnabled = site.NotificationEnabled;
            siteEntity.NotificationName = site.NotificationName;
            siteEntity.SharedCategories = site.SharedCategories;
            siteEntity.ControllerType = site.ControllerType;
            siteEntity.SnmpTemplateId = site.SnmpTemplateId;
            siteEntity.SnmpDataTemplateId = site.SnmpDataTemplateId;
            siteEntity.SecurityProtocol = site.SecurityProtocol;
        }

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

        public static SiteModelBase MapSiteToSiteModelBase(Site site)
        {
            return new SiteModelBase()
            {
                Id = site.Id,
                Description = site.Description,
                ParentId = site.ParentId
            };
        }
    }
}
