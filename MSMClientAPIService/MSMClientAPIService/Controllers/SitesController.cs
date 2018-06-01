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
using MSMClientAPIService.Enums;
using System;

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
        public IActionResult GetSiteByIds([FromBody] SiteViewRequest siteViewRequest)
            => Ok(this.siteService.GetSiteByIds(siteViewRequest));

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
        public async Task<IActionResult> AddNewSite([FromBody]SiteModel site)
        {
            var result = await this.siteService.AddNewSite(site);
            if (result == AddSiteResult.Ok)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        // GET api/sites
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> UpdateSites([FromBody]SiteUpdateRequest updateReq)
            => Ok(await this.siteService.UpdateSites(updateReq.Sites));

        // GET api/sites
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> DeleteSites([System.Web.Http.FromUri]List<int> siteIds)
            => Ok(await this.siteService.DeleteSites(siteIds));

        [HttpGet("lastId")]
        public IActionResult GetLastSiteID()
            => Ok(this.siteService.GetLastSiteID());
    }
}

