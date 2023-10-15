using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Eventures.Models
{
    public class RegisterViewModel
    {
        [Display(Prompt = "Username...", Name = "Username")]
        public string UserName { get; set; }

        [Display(Prompt = "Password...")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Prompt = "Confirm Password...")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Display(Prompt = "Email...")]
        public string Email { get; set; }

        [Display(Prompt = "First Name...")]
        public string FirstName { get; set; }

        [Display(Prompt = "Last Name...")]
        public string LastName { get; set; }

        [Display(Prompt = "Unique Citizen Number...")]
        public string UCN { get; set; }
    }
}
