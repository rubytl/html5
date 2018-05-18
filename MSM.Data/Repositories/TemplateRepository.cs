using System;
using MSM.Data.Models;
using MSM.Data.Repositories.Interfaces;

namespace MSM.Data.Repositories
{
    public class TemplateRepository : EntityBaseRepository<SiteTemplate>, ITemplateRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public TemplateRepository(Func<MultisiteDBEntitiesContext> context)
            : base(context)
        { }
    }
}
