using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MSMClientAPIService.Data.Models;
using MSMClientAPIService.Data.Repositories.Interfaces;
using MSMClientAPIService.Mapping.Models;

namespace MSMClientAPIService.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    [Authorize]
    [Route("api/[controller]")]
    public class SitesController : Controller
    {
        /// <summary>
        /// The sites repo
        /// </summary>
        private ISiteRepository sitesRepo;

        /// <summary>
        /// The mapper
        /// </summary>
        private IMapper mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="SitesController"/> class.
        /// </summary>
        /// <param name="repo">The repo.</param>
        /// <param name="mapper">The mapper.</param>
        public SitesController(ISiteRepository repo, IMapper mapper)
        {
            this.sitesRepo = repo;
            this.mapper = mapper;
        }

        // GET api/sites
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var sites = await sitesRepo.GetAll();
            return Ok(this.mapper.Map<IEnumerable<SiteModel>>(sites));
        }
    }
}
