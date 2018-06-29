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
        Task<IList<SiteModel>> GetSitePaging(PagingRequest pagingRequest);
        Task<IList<SiteModel>> GetFilteredSite(int filter, string siteName);
        Task<IEnumerable<SiteListViewDTO>> GetSitesListView(SiteViewRequest siteViewRequest);
        Task<AddSiteResult> AddNewSite(SiteModel site);
        Task<bool> UpdateSites(List<SiteModel> sites);
        Task<bool> DeleteSites(List<int> siteIds);
        int GetLastSiteID();
        IList<SiteModel> GetSiteByIds(SiteViewRequest siteViewRequest);
        IList<SiteModelBase> GetSitesByRestrictedGroupId(Guid groupId);
        IList<SiteModelBase> GetParentSites();
    }
}
