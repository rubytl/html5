using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MSM.Data.Repositories.Interfaces;

namespace MSMClientAPIService.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class TemplateController : Controller
    {
        private readonly ITemplateRepository templateRepo;
        public TemplateController(ITemplateRepository templateRepo)
        {
            this.templateRepo = templateRepo;
        }

        // GET: api/Template
        [HttpGet]
        public async Task<IActionResult> Get()
            => Ok(await this.templateRepo.GetAll());
    }
}
