using System.ComponentModel.DataAnnotations;

namespace Eventures.Models
{
    public class LoginViewModel
    {
        [Display(Prompt = "Username...", Name = "Username")]
        public string UserName { get; set; }

        [Display(Prompt = "Password...")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember Me?")]
        public bool RememberMe { get; set; }
    }
}
