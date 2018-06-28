using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MSM.Data.Models;

namespace MSM.Data.Repositories.Interfaces
{
    public interface IRestrictedGroupConfigRepository : IEntityBaseRepository<RestrictedGroupConfig>
    {
        IQueryable<RestrictedGroupConfig> GetConfigById(Guid id);
    }
}
