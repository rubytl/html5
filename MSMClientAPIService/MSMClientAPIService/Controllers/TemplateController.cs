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

        [HttpPost("all")]
        public async Task<IActionResult> GetSiteTemplates([FromBody] PagingRequest pagingRequest)
            => Ok(await this.siteTemplateService.GetSiteTemplates(pagingRequest));
    }
}
