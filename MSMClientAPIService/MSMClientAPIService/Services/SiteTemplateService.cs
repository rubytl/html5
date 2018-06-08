using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSM.Data.Models;
using MSM.Data.Repositories.Interfaces;
using MSMClientAPIService.Models;

namespace MSMClientAPIService.Services
{
    public class SiteTemplateService : ISiteTemplateService
    {
        private readonly ITemplateRepository templateRepo;
        public SiteTemplateService(ITemplateRepository templateRepo)
        {
            this.templateRepo = templateRepo;
        }

        public async Task<IEnumerable<SiteTemplate>> GetSiteTemplates(PagingRequest pagingRequest)
        {
            return await this.templateRepo.GetSiteTemplates(pagingRequest.PageIndex, pagingRequest.PageSize);
        }
    }
}
