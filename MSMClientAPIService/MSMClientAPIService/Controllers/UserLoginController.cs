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

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MSMClientAPIService.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class UserLoginController : Controller
    {

        private IUserMaintenanceRepository userRepo;
        public UserLoginController(IUserMaintenanceRepository userRepo)
        {
            this.userRepo = userRepo;
        }

        [HttpPut]
        public async Task<IActionResult> AddNewUserConfiguration([FromBody]UserLoginConfigurationModel userConfig)
        {
            try
            {
                await this.userRepo.AddAsync(UserLoginConfigurationMapping.MapModelToUserLoginConfiguration(userConfig));
                await this.userRepo.CommitAsync();
                var user = await this.userRepo.GetSingleAsync(s => s.UserName == userConfig.UserName);
                if (user != null)
                {
                    return Ok(user.Id);
                }

                return Ok(-1);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUserById([System.Web.Http.FromUri]int userId)
        {
            this.userRepo.DeleteWhere(s => s.Id == userId);
            await this.userRepo.CommitAsync();
            return Ok(true);
        }


        [HttpGet("users/{pageIndex}/{pageSize}")]
        public async Task<IActionResult> GetUserPaging(int pageIndex, int pageSize)
        {
            var result = await this.userRepo.GetAll();
            return Ok(result.Skip(pageIndex * pageSize).Take(pageSize));
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateUser([FromBody]UserUpdateRequest updateReq)
        {
            foreach (UserLoginConfigurationModel model in updateReq.Users)
            {
                var user = await this.userRepo.GetSingleAsync(s => s.Id == model.UserId);
                if (user != null)
                {
                    user.RoleName = model.RoleName;
                    user.RestrictedGroupId = model.RestrictedGroupID;
                }
            }

            await this.userRepo.CommitAsync();
            return Ok();
        }
    }
}
