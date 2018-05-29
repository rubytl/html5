using System;
using System.Collections.Generic;
using System.Text;
using MSM.Data.Models;
using MSM.Data.Repositories.Interfaces;

namespace MSM.Data.Repositories
{
    public class SiteNotificationRepository : EntityBaseRepository<SiteNotification>, ISiteNotificationRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteNotificationRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param> 
        public SiteNotificationRepository(Func<MultisiteDBEntitiesContext> context)
            : base(context)
        { }
    }
}
