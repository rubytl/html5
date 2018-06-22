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
using MSMAuthService.Helpers;
using MSMAuthService.Models;
using Microsoft.Extensions.Options;
using MSMAuthService.Services;

namespace MSMAuthService.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IAuthService authService;
        private readonly IJwtFactory jwtFactory;

        public AuthController(IJwtFactory jwtFactory, IAuthService authService)
        {
            this.jwtFactory = jwtFactory;
            this.authService = authService;
        }

        [HttpGet("validate/{token}")]
        public async Task<IActionResult> ValidateToken(string token)
        {
            ClaimsPrincipal principal = await this.jwtFactory.GetPrincipal(token);
            if (principal == null)
            {
                return BadRequest(Errors.AddErrorToModelState("Failed", "Token invalid", ModelState));
            }

            return Ok();
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginModel credentials)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var loginStatus = await this.authService.CheckLogin(credentials.Username, credentials.Password);
            CheckLoginResult result = loginStatus.CheckLoginResult;
            if (result == CheckLoginResult.Allowed)
            {
                return Ok(await this.jwtFactory.GenerateJwtToken(credentials.Username));
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("refresh")]
        [AllowAnonymous]
        public async Task<IActionResult> RefreshAccessToken([FromBody]RefreshTokenModel token)
            => Ok(await this.authService.RefreshAccessToken(token.Token));

        [HttpPost("logout")]
        [AllowAnonymous]
        public async Task<IActionResult> Logout([FromBody]RefreshTokenModel token)
          => Ok(await this.authService.Logout(token.Token));

        [HttpPost("revoke")]
        public IActionResult RevokeRefreshToken([FromBody]RefreshTokenModel token)
        {
            this.authService.RevokeRefreshToken(token.Token);
            return NoContent();
        }

        [HttpPut("register")]
        public async Task<IActionResult> Register([FromBody]RegisterModel model)
        {
            try
            {
                var newUser = await this.authService.CreateNewUser(model);
                if (newUser is RegisterModelResponse)
                {
                    RegisterModelResponse res = (RegisterModelResponse)newUser;
                    return Ok(new { id = res.Id, createdDate = res.CreatedDate });
                }
                else
                {
                    return BadRequest((newUser as IdentityError).Description);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("forgotPw")]
        [AllowAnonymous]
        public async Task<IActionResult> ForgotPassword(string email)
            => Ok(await this.authService.ForgotPassword(email));

        [HttpPost("resetPw")]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPassword([FromBody]ResetPasswordModel model)
            => Ok(await this.authService.ResetPassword(model));

        [HttpPost("newRole")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateNewRole(string roleName)
           => Ok(await this.authService.CreateNewRole(roleName));

        [HttpGet("roles")]
        [AllowAnonymous]
        public IActionResult GetRoles()
           => Ok(this.authService.GetRoles());

        [HttpGet("users/{pageIndex}/{pageSize}")]
        [AllowAnonymous]
        public IActionResult GetUsers(int pageIndex, int pageSize)
           => Ok(this.authService.GetUsers(pageIndex, pageSize));

        [HttpDelete]
        public async Task<IActionResult> DeleteUserById([System.Web.Http.FromUri]string userId)
            => Ok(await this.authService.DeleteUserById(userId));

        [HttpPut("unlock")]
        public async Task<IActionResult> UnlockUser([FromBody]List<string> userIds)
            => Ok(await this.authService.UnlockUser(userIds));

        [HttpPut("lastlogin")]
        public async Task<IActionResult> UpdateLastLogin([FromBody]LoginModel loginModel)
           => Ok(await this.authService.UpdateLastLogin(loginModel.Username));
    }
}