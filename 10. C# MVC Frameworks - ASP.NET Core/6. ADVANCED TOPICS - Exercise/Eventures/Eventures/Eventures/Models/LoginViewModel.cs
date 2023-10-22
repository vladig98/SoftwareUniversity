using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;

namespace Eventures.Models
{
    public class LoginViewModel
    {
        public LoginViewModel()
        {
            ExternalLogins = new List<AuthenticationScheme>();
        }

        [Display(Prompt = "Username...", Name = "Username")]
        public string UserName { get; set; }

        [Display(Prompt = "Password...")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember Me?")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
        public IList<AuthenticationScheme> ExternalLogins { get; set; }
    }
}
