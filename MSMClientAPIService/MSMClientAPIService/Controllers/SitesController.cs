using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MSM.Data.Models;
using MSM.Data.Repositories.Interfaces;
using MSMClientAPIService.Helpers;
using MSMClientAPIService.Mapping.Models;
using System.Linq;
using MSMClientAPIService.Models;

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
        private ISiteRepository siteRepo;

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
            this.siteRepo = repo;
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
            var sites = await siteRepo.GetAll();
            return Ok(this.mapper.Map<IEnumerable<SiteModel>>(sites));
        }

        // GET api/sites
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        [HttpGet("filter/{filter}/{siteName}")]
        public async Task<IActionResult> GetFilteredSite(int filter, string siteName)
        {
            var sites = await siteRepo.GetSiteListFiltered(filter, siteName);
            List<Site> result = new List<Site>();
            foreach (Site site in sites)
            {
                this.TraverseSiteParents(site, result);
                await this.TraverseSiteChildren(site, result);
            }

            return Ok(this.mapper.Map<IEnumerable<SiteModel>>(result));
        }


        [HttpPost("siteview")]
        public async Task<IActionResult> GetSitesListView([FromBody] SiteViewRequest siteViewRequest)
            => Ok(await this.siteRepo.GetSitesListView(siteViewRequest.SiteIds, siteViewRequest.PageIndex, siteViewRequest.PageSize));


        /// <summary>
        /// Travers the site group.
        /// </summary>
        /// <param name="site">The site.</param>
        /// <returns>
        /// The list of site
        /// </returns>
        private async Task TraverseSiteChildren(Site site, List<Site> chilren)
        {
            var directChilds = await this.siteRepo.FindBy(s => s.ParentId == site.Id);
            if (directChilds != null)
            {
                foreach (Site directChild in directChilds)
                {
                    if (!chilren.Contains(directChild))
                    {
                        chilren.Add(directChild);
                    }

                    await this.TraverseSiteChildren(directChild, chilren);
                }
            }
        }

        /// <summary>
        /// Travers the site group.
        /// </summary>
        /// <param name="site">The site.</param>
        /// <returns>
        /// The list of site
        /// </returns>
        private void TraverseSiteParents(Site site, List<Site> parents)
        {
            if (site != null)
            {
                if (!parents.Contains(site))
                {
                    parents.Add(site);
                }

                this.TraverseSiteParents(site.Parent, parents);
            }
        }
    }
}

