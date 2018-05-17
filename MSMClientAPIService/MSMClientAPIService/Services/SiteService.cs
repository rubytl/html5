using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSM.Data.Models;
using MSM.Data.PresentationModel;
using MSM.Data.Repositories.Interfaces;
using MSMClientAPIService.Enums;
using MSMClientAPIService.Mapping;
using MSMClientAPIService.Mapping.Models;
using MSMClientAPIService.Models;
using Tørketrommel;

namespace MSMClientAPIService.Services
{
    public class SiteService : ISiteService
    {
        private ISiteRepository siteRepo;
        public SiteService(ISiteRepository siteRepo)
        {
            this.siteRepo = siteRepo;
        }

        public async Task<IList<SiteModel>> GetSites()
        {
            var sites = await siteRepo.GetAll();
            return this.DoMappingSiteToSiteModel(sites);
        }

        public async Task<IEnumerable<SiteListViewDTO>> GetSitesListView(SiteViewRequest siteViewRequest)
        {
            return await this.siteRepo.GetSitesListView(siteViewRequest.SiteIds, siteViewRequest.PageIndex, siteViewRequest.PageSize);
        }

        public async Task<IList<SiteModel>> GetSiteByIds(SiteViewRequest siteViewRequest)
        {
            var sites = await siteRepo.FindByAsync(s => siteViewRequest.SiteIds.Contains(s.Id));
            sites = sites.Skip(siteViewRequest.PageIndex * siteViewRequest.PageSize).Take(siteViewRequest.PageSize);
            return this.DoMappingSiteToSiteModel(sites);
        }

        /// <summary>
        /// Travers the site group.
        /// </summary>
        /// <param name="site">The site.</param>
        /// <returns>
        /// The list of site
        /// </returns>
        private async Task TraverseSiteChildren(Site site, List<Site> chilren)
        {
            var directChilds = await this.siteRepo.FindByAsync(s => s.ParentId == site.Id);
            if (directChilds != null)
            {
                foreach (Site directChild in directChilds)
                {
                    if (!chilren.Contains(directChild))
                    {
                        chilren.Add(directChild);
                    }

                    await this.TraverseSiteChildren(directChild, chilren);
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
                await this.TraverseSiteChildren(site, result);
            }

            return this.DoMappingSiteToSiteModel(sites);
        }

        private List<SiteModel> DoMappingSiteToSiteModel(IQueryable<Site> sites)
        {
            List<SiteModel> result = new List<SiteModel>();
            foreach (var site in sites)
            {
                result.Add(SiteMappingProfile.MapSiteToSiteModel(site));
            }

            return result;
        }

        public async Task<bool> UpdateSite(int siteId)
        {
            var site = await this.siteRepo.GetSingleAsync(s => s.Id == siteId);
            this.siteRepo.Update(site);
            this.siteRepo.Commit();
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteSite(int siteId)
        {
            var site = await this.siteRepo.GetSingleAsync(s => s.Id == siteId);
            this.siteRepo.Delete(site);
            this.siteRepo.Commit();
            return await Task.FromResult(true);
        }

        public async Task<AddSiteResult> AddNewSite(SiteModel site)
        {
            AddSiteResult result = await this.CanAddSite();
            if (result == AddSiteResult.Ok)
            {
                this.siteRepo.Add(SiteMappingProfile.MapSiteModelToSite(site));
                this.siteRepo.Commit();
            }

            return await Task.FromResult(result);
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
    }
}
