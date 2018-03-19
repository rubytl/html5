using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MSMClientAPIService.Helpers;
using MSMClientAPIService.Data.Repositories;
using MSMClientAPIService.Data.Repositories.Interfaces;
using MSMClientAPIService.Models;
using Microsoft.Extensions.Options;

namespace MSMClientAPIService.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IConfiguration config;
        private readonly IUserMaintenanceRepository userRepo;
        private readonly IJwtFactory jwtFactory;
        private JwtIssuerOptions jwtOptions;

        public AuthController(IConfiguration config, IUserMaintenanceRepository userRepo, IJwtFactory jwtFactory, IOptions<JwtIssuerOptions> jwtOptions)
        {
            this.config = config;
            this.userRepo = userRepo;
            this.jwtFactory = jwtFactory;
            this.jwtOptions = jwtOptions.Value;
        }

        [HttpGet]
        public async Task<IActionResult> ValidateToken(string token)
        {
            ClaimsPrincipal principal = await this.jwtFactory.GetPrincipal(token);
            if (principal == null)
            {
                return BadRequest(Errors.AddErrorToModelState("Failed", "Token invalid", ModelState));
            }

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginModel credentials)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var loginStatus = await this.userRepo.CheckLogin(credentials.Username, credentials.Password);
            CheckLoginResult result = loginStatus.CheckLoginResult;
            if (result == CheckLoginResult.Allowed)
            {
                return Ok(await Tokens.GenerateJwt(this.jwtFactory, credentials.Username, this.jwtOptions));
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}