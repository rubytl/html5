using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MSM.Data.Models;
using MSM.Data.Repositories.Interfaces;

namespace MSM.Data.Repositories
{
    public class MSMDictionaryRepository : EntityBaseRepository<Msmdictionary>, IMSMDictionaryRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public MSMDictionaryRepository(Func<MultisiteDBEntitiesContext> context)
            : base(context)
        { }

        public IQueryable<Msmdictionary> GetMsmDictionaryById(string itemId)
        {
            return this.FindBy(s => s.ItemId.StartsWith(itemId));
        }
    }
}
