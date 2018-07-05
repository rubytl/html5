using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MSMAuthService.Models
{
    public class UserUpdateRequest
    {
        public List<RegisterModel> Users;
    }

    public class RefreshTokenModel
    {
        public string Token { get; set; }
    }

    public class LoginModel
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }

    public class RegisterModelResponse
    {
        public string Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class RegisterModel
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Comment { get; set; }

        public bool Locked { get; set; }

        public string FriendlyName { get; set; }

        public string RoleName { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? LastLogin { get; set; }
    }

    public class ResetPasswordModel
    {
        public string Code { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }
    }
}
