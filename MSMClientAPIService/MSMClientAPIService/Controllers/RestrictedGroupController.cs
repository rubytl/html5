using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MSM.Data.Repositories.Interfaces;

namespace MSMClientAPIService.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class RestrictedGroupController : Controller
    {
        /// <summary>
        /// The sites repo
        /// </summary>
        private IRestrictedGroupRepository restrictedGroup;

        /// <summary>
        /// Initializes a new instance of the <see cref="SitesController"/> class.
        /// </summary>
        /// <param name="repo">The repo.</param>
        /// <param name="mapper">The mapper.</param>
        public RestrictedGroupController(IRestrictedGroupRepository restrictedGroup)
        {
            this.restrictedGroup = restrictedGroup;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
            => Ok(await this.restrictedGroup.GetAll());
    }
}