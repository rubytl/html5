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
        private IUserMaintenanceRepository userRepo;
        public RestrictedGroupConfigurationController(IRestrictedGroupConfigRepository configRepository, IRestrictedGroupRepository groupRepository,
            IUserMaintenanceRepository userRepo)
        {
            this.configRepository = configRepository;
            this.groupRepository = groupRepository;
            this.userRepo = userRepo;
        }

        // GET api/sites
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> UpdateGroupConfig([FromBody]RestrictedGroupConfigUpdateRequest updateReq)
        {
            try
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

                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }


        /// <summary>
        /// Deletes the restricted group.
        /// </summary>
        /// <param name="siteIds">The site ids.</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> DeleteRestrictedGroup([System.Web.Http.FromUri]List<Guid> groupIds)
        {
            try
            {
                // delete records in restrictedgroup table
                this.groupRepository.DeleteWhere(s => groupIds.Contains(s.RestrictedGroupId));

                // delete records in restrictedgorupconfig table
                this.configRepository.DeleteWhere(s => groupIds.Contains(s.RestrictedGroupId));

                // save changes
                await this.configRepository.CommitAsync();
                await this.groupRepository.CommitAsync();
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet("canDelete")]
        public async Task<IActionResult> CanDeleteConfig([System.Web.Http.FromUri]Guid groupId)
        {
            var result =  !(await this.userRepo.HasAnyAsync(s => s.RestrictedGroupId == groupId));
            return Ok(result);
        }
    }
}