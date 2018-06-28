using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSM.Data.Models;
using MSM.Data.PresentationModel;

namespace MSM.Data.Repositories.Interfaces
{
    public interface ISiteRepository : IEntityBaseRepository<Site>
    {
        Task<IQueryable<Site>> GetSiteListFiltered(int filter, string siteName);

        /// <summary>
        /// Gets the sites ListView.
        /// </summary>
        /// <param name="siteIds">The site ids.</param>
        /// <param name="pageIndex">Index of the page.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns></returns>
        Task<IEnumerable<SiteListViewDTO>> GetSitesListView(List<int> siteIds, int pageIndex, int pageSize);

        int GetLastSiteID();

        IQueryable<Site> GetSiteByIds(IQueryable<int> ids);

        IQueryable<Site> GetParentSites();
    }
}
