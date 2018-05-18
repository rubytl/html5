using System;
using System.Collections.Generic;
using System.Text;
using MSM.Data.Models;
using MSM.Data.Repositories.Interfaces;

namespace MSM.Data.Repositories
{
    public class SnmpConfigTemplateRepository : EntityBaseRepository<SnmpconfigTemplate>, ISnmpConfigTemplateRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public SnmpConfigTemplateRepository(Func<MultisiteDBEntitiesContext> context)
            : base(context)
        { }
    }
}
