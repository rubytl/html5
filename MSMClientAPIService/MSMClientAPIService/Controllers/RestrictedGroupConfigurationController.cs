using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MSM.Data.Models;
using MSM.Data.Repositories.Interfaces;
using MSMClientAPIService.Mapping;
using MSMClientAPIService.Mapping.Models;
using MSMClientAPIService.Models;

namespace MSMClientAPIService.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class RestrictedGroupConfigurationController : Controller
    {
        private IRestrictedGroupConfigRepository configRepository;

        private IRestrictedGroupRepository groupRepository;
        public RestrictedGroupConfigurationController(IRestrictedGroupConfigRepository configRepository, IRestrictedGroupRepository groupRepository)
        {
            this.configRepository = configRepository;
            this.groupRepository = groupRepository;
        }

        // GET api/sites
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> UpdateGroupConfig([FromBody]RestrictedGroupConfigUpdateRequest updateReq)
        {
            bool hasDeleted = false;
            foreach (IGrouping<Guid, object> restrictedGroup in updateReq.GroupConfig.GroupBy(s => s.RestrictedGroupId))
            {
                var existingConfigs = this.configRepository.FindBy(s => s.RestrictedGroupId == restrictedGroup.Key);
                // delete existing configs
                foreach (var existingConfig in existingConfigs)
                {
                    hasDeleted = true;
                    this.configRepository.Delete(existingConfig);
                }
            }

            if (hasDeleted)
            {
                await this.configRepository.CommitAsync();
            }

            // add new configs
            foreach (IGrouping<Guid, RestrictedGroupConfigurationModel> restrictedGroup in updateReq.GroupConfig.GroupBy(s => s.RestrictedGroupId))
            {
                // add or update restricted group information
                var existingGroup = await this.groupRepository.GetSingleAsync(s => s.RestrictedGroupId == restrictedGroup.Key);
                var restrictedItem = restrictedGroup.ElementAt(0);
                if (existingGroup == null)
                {
                    await this.groupRepository.AddAsync(RestrictedGroupMapping.MapModelToRestrictedGroup(restrictedItem));
                }
                else
                {
                    existingGroup.RestrictedGroupName = restrictedItem.RestrictedGroupName;
                }

                foreach (RestrictedGroupConfigurationModel model in restrictedGroup)
                {
                    // add restricted group configuration
                    await this.configRepository.AddAsync(RestrictedGroupMapping.MapModelToGroupConfiguration(model));
                }
            }

            await this.groupRepository.CommitAsync();
            await this.configRepository.CommitAsync();

            return Ok(true);
        }
    }
}