using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSM.Data.Models;
using MSMClientAPIService.Models;

namespace MSMClientAPIService.Services
{
    public interface ISiteTemplateService
    {
        Task<IEnumerable<SiteTemplate>> GetSiteTemplates(PagingRequest pagingRequest);
        Task<bool> DeleteSiteTemplates(List<string> templateIds);
        Task<bool> CanDeleteTemplate(string templateId);
    }
}
