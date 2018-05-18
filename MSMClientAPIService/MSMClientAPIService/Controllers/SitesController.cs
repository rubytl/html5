using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MSM.Data.Models;
using MSM.Data.Repositories.Interfaces;
using MSMClientAPIService.Helpers;
using MSMClientAPIService.Mapping.Models;
using System.Linq;
using MSMClientAPIService.Models;
using MSMClientAPIService.Mapping;
using MSMClientAPIService.Services;

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
        private ISiteService siteService;

        /// <summary>
        /// Initializes a new instance of the <see cref="SitesController"/> class.
        /// </summary>
        /// <param name="repo">The repo.</param>
        /// <param name="mapper">The mapper.</param>
        public SitesController(ISiteService siteService)
        {
            this.siteService = siteService;
        }

        // GET api/sites
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
            => Ok(await this.siteService.GetSites());

        [HttpPost("siteByIds")]
        public async Task<IActionResult> GetSiteByIds([FromBody] SiteViewRequest siteViewRequest)
            => Ok(await this.siteService.GetSiteByIds(siteViewRequest));

        // GET api/sites
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        [HttpGet("filter/{filter}/{siteName}")]
        public async Task<IActionResult> GetFilteredSite(int filter, string siteName)
           => Ok(await this.siteService.GetFilteredSite(filter, siteName));


        [HttpPost("siteview")]
        public async Task<IActionResult> GetSitesListView([FromBody] SiteViewRequest siteViewRequest)
            => Ok(await this.siteService.GetSitesListView(siteViewRequest));

        // GET api/sites
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        [HttpPost("add")]
        public IActionResult AddNewSite([FromBody]SiteModel site)
            => Ok(this.siteService.AddNewSite(site));

        // GET api/sites
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        [HttpPut("update")]
        public IActionResult UpdateSite(int siteId)
            => Ok(this.siteService.UpdateSite(siteId));

        // GET api/sites
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        [HttpPost("delete")]
        public IActionResult DeleteSite(int siteId)
            => Ok(this.siteService.DeleteSite(siteId));
    }
}

