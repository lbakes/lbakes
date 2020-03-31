using System;
using System.ComponentModel.DataAnnotations;

namespace CWheelsApi.Models
{
    public class ChangePasswordModel
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }

        [Compare("NewPassword", ErrorMessage = "The new password and the confirm password do not match")]
        public string ConfirmPassword { get; set; }
    }
}
