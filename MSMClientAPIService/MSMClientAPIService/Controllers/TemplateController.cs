using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MSM.Data.Repositories.Interfaces;
using MSMClientAPIService.Models;
using MSMClientAPIService.Services;

namespace MSMClientAPIService.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class TemplateController : Controller
    {
        private readonly ITemplateRepository templateRepo;
        private readonly ISiteTemplateService siteTemplateService;

        public TemplateController(ITemplateRepository templateRepo, ISiteTemplateService siteTemplateService)
        {
            this.templateRepo = templateRepo;
            this.siteTemplateService = siteTemplateService;
        }

        // GET: api/Template
        [HttpGet]
        public async Task<IActionResult> Get()
            => Ok(await this.templateRepo.GetAll());

        [HttpGet("canDelete")]
        public async Task<IActionResult> CanDeleteTemplate([System.Web.Http.FromUri]string templateId)
            => Ok(await this.siteTemplateService.CanDeleteTemplate(templateId));


        [HttpPost("all")]
        public async Task<IActionResult> GetSiteTemplates([FromBody] PagingRequest pagingRequest)
            => Ok(await this.siteTemplateService.GetSiteTemplates(pagingRequest));

        [HttpDelete]
        public async Task<IActionResult> DeleteSiteTemplates([System.Web.Http.FromUri]List<string> templateIds)
            => Ok(await this.siteTemplateService.DeleteSiteTemplates(templateIds));
    }
}
