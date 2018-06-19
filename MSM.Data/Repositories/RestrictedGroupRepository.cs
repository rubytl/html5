using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using MSM.Data.Models;
using MSM.Data.Repositories.Interfaces;

namespace MSM.Data.Repositories
{
    public class RestrictedGroupRepository: EntityBaseRepository<RestrictedGroup>, IRestrictedGroupRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictedGroupRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public RestrictedGroupRepository(Func<MultisiteDBEntitiesContext> context)
            : base(context)
        { }
    }
}
