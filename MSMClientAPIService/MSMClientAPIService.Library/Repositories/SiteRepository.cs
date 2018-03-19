using System;
using System.Collections.Generic;
using System.Text;
using MSMClientAPIService.Data.Models;
using MSMClientAPIService.Data.Repositories.Interfaces;

namespace MSMClientAPIService.Data.Repositories
{
    public class SiteRepository : EntityBaseRepository<Site>, ISiteRepository
    {
        public SiteRepository(MultisiteDBEntitiesContext context)
            : base(context)
        { }
    }
}
