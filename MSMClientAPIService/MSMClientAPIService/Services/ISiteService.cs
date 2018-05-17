using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSM.Data.PresentationModel;
using MSMClientAPIService.Enums;
using MSMClientAPIService.Mapping.Models;
using MSMClientAPIService.Models;

namespace MSMClientAPIService.Services
{
    public interface ISiteService
    {
        Task<IList<SiteModel>> GetSites();
        Task<IList<SiteModel>> GetFilteredSite(int filter, string siteName);
        Task<IEnumerable<SiteListViewDTO>> GetSitesListView(SiteViewRequest siteViewRequest);
        Task<AddSiteResult> AddNewSite(SiteModel site);
        Task<bool> UpdateSite(int siteId);
        Task<bool> DeleteSite(int siteId);

        Task<IList<SiteModel>> GetSiteByIds(SiteViewRequest siteViewRequest);
    }
}
