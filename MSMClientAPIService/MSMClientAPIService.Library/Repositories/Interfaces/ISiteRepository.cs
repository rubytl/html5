using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSMClientAPIService.Data.Models;

namespace MSMClientAPIService.Data.Repositories.Interfaces
{
    public interface ISiteRepository : IEntityBaseRepository<Site>
    {
        Task<IQueryable<Site>> GetSiteListFiltered(int filter, string siteName);
    }
}
