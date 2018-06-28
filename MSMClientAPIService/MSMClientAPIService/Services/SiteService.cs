using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MSM.Common.Helpers;
using MSM.Data.Models;
using MSM.Data.PresentationModel;
using MSM.Data.Repositories.Interfaces;
using MSMClientAPIService.Enums;
using MSMClientAPIService.Mapping;
using MSMClientAPIService.Mapping.Models;
using MSMClientAPIService.Models;
using MSMEnumerations;
using Tørketrommel;

namespace MSMClientAPIService.Services
{
    public class SiteService : ISiteService
    {
        private ISiteRepository siteRepo;
        private INetworkDeviceRepository networkDeviceRepo;
        private ISiteNotificationRepository siteNotiRepo;
        private IRestrictedGroupRepository groupRepo;
        private IRestrictedGroupConfigRepository groupConfigRepo;
        public SiteService(ISiteRepository siteRepo, INetworkDeviceRepository networkDeviceRepo, ISiteNotificationRepository siteNotiRepo,
            IRestrictedGroupRepository groupRepo, IRestrictedGroupConfigRepository groupConfigRepo)
        {
            this.siteRepo = siteRepo;
            this.networkDeviceRepo = networkDeviceRepo;
            this.siteNotiRepo = siteNotiRepo;
            this.groupRepo = groupRepo;
            this.groupConfigRepo = groupConfigRepo;
        }
        public async Task<IList<SiteModel>> GetSites()
        {
            var sites = await siteRepo.GetAll();
            return this.DoMappingSiteToSiteModel(sites);
        }

        public async Task<IList<SiteModel>> GetSitePaging(PagingRequest pagingRequest)
        {
            var sites = await siteRepo.GetAll();
            return this.DoMappingSiteToSiteModel(sites.Skip(pagingRequest.PageIndex * pagingRequest.PageSize).Take(pagingRequest.PageSize));
        }

        public async Task<IEnumerable<SiteListViewDTO>> GetSitesListView(SiteViewRequest siteViewRequest)
        {
            return await this.siteRepo.GetSitesListView(siteViewRequest.SiteIds, siteViewRequest.PageIndex, siteViewRequest.PageSize);
        }

        public IList<SiteModel> GetSiteByIds(SiteViewRequest siteViewRequest)
        {
            var sites = siteRepo.FindBy(s => siteViewRequest.SiteIds.Contains(s.Id));
            sites = sites.Skip(siteViewRequest.PageIndex * siteViewRequest.PageSize).Take(siteViewRequest.PageSize);
            return this.DoMappingSiteToSiteModel(sites);
        }

        public int GetLastSiteID()
        {
            return siteRepo.GetLastSiteID();
        }

        /// <summary>
        /// Travers the site group.
        /// </summary>
        /// <param name="site">The site.</param>
        /// <returns>
        /// The list of site
        /// </returns>
        private void TraverseSiteChildren(Site site, List<Site> chilren)
        {
            var directChilds = this.siteRepo.FindBy(s => s.ParentId == site.Id);
            if (directChilds != null)
            {
                foreach (Site directChild in directChilds)
                {
                    if (!chilren.Contains(directChild))
                    {
                        chilren.Add(directChild);
                    }

                    this.TraverseSiteChildren(directChild, chilren);
                }
            }
        }

        /// <summary>
        /// Travers the site group.
        /// </summary>
        /// <param name="site">The site.</param>
        /// <returns>
        /// The list of site
        /// </returns>
        private void TraverseSiteParents(Site site, List<Site> parents)
        {
            if (site != null)
            {
                if (!parents.Contains(site))
                {
                    parents.Add(site);
                }

                this.TraverseSiteParents(site.Parent, parents);
            }
        }

        public async Task<IList<SiteModel>> GetFilteredSite(int filter, string siteName)
        {
            var sites = await siteRepo.GetSiteListFiltered(filter, siteName);
            List<Site> result = new List<Site>();
            foreach (Site site in sites)
            {
                this.TraverseSiteParents(site, result);
                this.TraverseSiteChildren(site, result);
            }

            return this.DoMappingSiteToSiteModel(result);
        }

        private List<SiteModel> DoMappingSiteToSiteModel(IEnumerable<Site> sites)
        {
            List<SiteModel> result = new List<SiteModel>();
            foreach (var site in sites)
            {
                result.Add(SiteMappingProfile.MapSiteToSiteModel(site));
            }

            return result;
        }

        public async Task<bool> UpdateSites(List<SiteModel> sites)
        {
            foreach (var site in sites)
            {
                var siteEntity = await this.siteRepo.GetSingleAsync(s => site.Id == s.Id);
                if (siteEntity != null)
                {
                    SiteMappingProfile.MapSiteModelToExistingSite(site, siteEntity);
                }
            }

            // Attempt to save changes to the database
            await this.siteRepo.CommitAsync();
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteSites(List<int> siteIds)
        {
            this.siteRepo.DeleteWhere(s => siteIds.Contains(s.Id));
            await this.siteRepo.CommitAsync();
            return await Task.FromResult(true);
        }

        public async Task<AddSiteResult> AddNewSite(SiteModel site)
        {
            //AddSiteResult result = await this.CanAddSite();
            //if (result == AddSiteResult.Ok)
            //{
            //    await this.siteRepo.AddAsync(SiteMappingProfile.MapSiteModelToSite(site));
            //    await this.siteRepo.Commit();
            //}

            if (!string.IsNullOrEmpty(site.Address))
            {
                var shouldDefineSecurityProtocol = ControllerTypeHelper.ShouldDefineSecurityProtocol((ControllerTypeEnum)site.ControllerType);
                if (shouldDefineSecurityProtocol)
                {
                    var securityProtocol = SecurityProtocolEnum.Ssl3;
                    var controllerInfo = await this.networkDeviceRepo.GetSingleAsync(s => s.Ipaddress == site.Address);
                    if (controllerInfo != null)
                    {
                        securityProtocol = controllerInfo.UseTls12 ? SecurityProtocolEnum.Tls12 : SecurityProtocolEnum.Ssl3;
                    }

                    site.SecurityProtocol = (byte)securityProtocol;
                }
            }

            // Update NotificationID base on parent's Site/Group
            await this.AddNewNotification(site);
            await this.siteRepo.AddAsync(SiteMappingProfile.MapSiteModelToSite(site));
            await this.siteRepo.CommitAsync();

            return await Task.FromResult(AddSiteResult.Ok);
        }

        private async Task AddNewNotification(SiteModel site)
        {
            if (site.ParentId.HasValue)
            {
                var notificationParent = this.siteNotiRepo.FindBy(sn => sn.SiteId == site.ParentId);

                // Insert new notification
                foreach (var newItem in notificationParent)
                {
                    SiteNotification newSiteNotification = new SiteNotification
                    {
                        SiteId = site.Id,
                        NotificationId = newItem.NotificationId,
                        InheritedNotification = newItem.InheritedNotification,
                        InheritedReceiver = newItem.InheritedReceiver,
                        DefaultReceiver = newItem.DefaultReceiver,
                        Enabled = newItem.Enabled,
                    };

                    // Add New
                    await this.siteNotiRepo.AddAsync(newSiteNotification);
                }
            }
        }

        private async Task<AddSiteResult> CanAddSite()
        {
            try
            {
                var licenseStatus = Tørketrommel.Tørketrommel.Instance().Status;

                if (licenseStatus == enumTørketrommel.NotValid || licenseStatus == enumTørketrommel.ServerDateBeforeLicenseStartDate)
                {
                    return AddSiteResult.LicenseInvalid;
                }

                if (licenseStatus == enumTørketrommel.ExpiredDueToInternalCounter || licenseStatus == enumTørketrommel.ExpiredDueToServerClock)
                {
                    return AddSiteResult.LicenseExpired;
                }

                int numberOfSites = await this.siteRepo.CountWhereAsync(sites => !string.IsNullOrEmpty(sites.Address));

                if (numberOfSites >= Tørketrommel.Tørketrommel.Instance().NumberOfSites)
                {
                    return AddSiteResult.LimitExceeded;
                }

                return AddSiteResult.Ok;
            }
            catch
            {
                return AddSiteResult.FailedToCheck;
            }
        }

        public IList<SiteModel> GetSitesByRestrictedGroupId(Guid groupId)
        {
            var configResult = this.groupConfigRepo.GetConfigById(groupId);
            var siteResult = this.siteRepo.GetSiteByIds(configResult.Select(s => s.SiteId));
            return this.DoMappingSiteToSiteModel(siteResult);
        }

        public IList<SiteModelBase> GetParentSites()
        {
            var sites = this.siteRepo.GetParentSites();
            List<SiteModelBase> result = new List<SiteModelBase>();
            foreach (var site in sites)
            {
                result.Add(SiteMappingProfile.MapSiteToSiteModelBase(site));
            }

            return result;
        }
    }
}
