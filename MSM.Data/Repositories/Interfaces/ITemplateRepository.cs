using System.Collections.Generic;
using System.Threading.Tasks;
using MSM.Data.Models;

namespace MSM.Data.Repositories.Interfaces
{
    public interface ITemplateRepository : IEntityBaseRepository<SiteTemplate>
    {
        Task<IEnumerable<SiteTemplate>> GetSiteTemplates(int pageIndex, int pageSize);
    }
}
