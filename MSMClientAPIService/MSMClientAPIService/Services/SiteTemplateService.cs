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
        private readonly ISiteRepository siteRepo;
        public SiteTemplateService(ITemplateRepository templateRepo, ISiteRepository siteRepo)
        {
            this.templateRepo = templateRepo;
            this.siteRepo = siteRepo;
        }

        public async Task<IEnumerable<SiteTemplate>> GetSiteTemplates(PagingRequest pagingRequest)
        {
            return await this.templateRepo.GetSiteTemplates(pagingRequest.PageIndex, pagingRequest.PageSize);
        }

        public async Task<bool> CanDeleteTemplate(string templateId)
        {
            return !(await this.siteRepo.HasAnyAsync(s => s.TemplateId == templateId));
        }

        public async Task<bool> DeleteSiteTemplates(List<string> templateIds)
        {
            this.templateRepo.DeleteWhere(s => templateIds.Contains(s.TemplateId));
            await this.templateRepo.CommitAsync();
            return await Task.FromResult(true);
        }
    }
}
