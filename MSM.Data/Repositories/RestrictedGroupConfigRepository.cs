using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSM.Data.Models;
using MSM.Data.Repositories.Interfaces;

namespace MSM.Data.Repositories
{
    public class RestrictedGroupConfigRepository : EntityBaseRepository<RestrictedGroupConfig>, IRestrictedGroupConfigRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictedGroupRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public RestrictedGroupConfigRepository(Func<MultisiteDBEntitiesContext> context)
            : base(context)
        { }

        public IQueryable<RestrictedGroupConfig> GetConfigById(Guid id)
        {
            return this.FindBy(s => s.RestrictedGroupId == id);
        }
    }
}
