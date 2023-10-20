using System.ComponentModel.DataAnnotations;

namespace Eventures.Models
{
    public class RegisterViewModel
    {
        [Display(Prompt = "Username...", Name = "Username")]
        [Required]
        [StringLength(100, MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-Z0-9-_.*~]+$")]
        public string UserName { get; set; }

        [Display(Prompt = "Password...")]
        [DataType(DataType.Password)]
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Password { get; set; }

        [Display(Prompt = "Confirm Password...")]
        [DataType(DataType.Password)]
        [Required]
        [StringLength(100, MinimumLength = 5)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        [Display(Prompt = "Email...")]
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Display(Prompt = "First Name...")]
        public string FirstName { get; set; }

        [Display(Prompt = "Last Name...")]
        public string LastName { get; set; }

        [Display(Prompt = "Unique Citizen Number...")]
        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string UCN { get; set; }
    }
}
