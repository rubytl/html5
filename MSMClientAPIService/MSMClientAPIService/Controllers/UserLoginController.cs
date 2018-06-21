using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MSM.Data.Models;
using MSM.Data.Repositories.Interfaces;
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
        public async Task<IActionResult> AddNewUserConfiguration([FromBody]UserLoginConfiguration userConfig)
        {
            await this.userRepo.AddAsync(userConfig);
            await this.userRepo.CommitAsync();

            return Ok(true);
        }


        [HttpGet("users/{pageIndex}/{pageSize}")]
        public async Task<IActionResult> GetUserPaging(int pageIndex, int pageSize)
        {
            var result = await this.userRepo.GetAll();
            return Ok(result.Skip(pageIndex * pageSize).Take(pageSize));
        }
    }
}
