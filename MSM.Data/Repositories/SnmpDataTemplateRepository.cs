using System;
using MSM.Data.Models;
using MSM.Data.Repositories.Interfaces;

namespace MSM.Data.Repositories
{
    public class SnmpDataTemplateRepository: EntityBaseRepository<SnmpDataTemplate>, ISnmpDataTemplateRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnmpDataTemplateRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public SnmpDataTemplateRepository(Func<MultisiteDBEntitiesContext> context)
            : base(context)
        { }
    }
}
