using System.ComponentModel.DataAnnotations;

namespace CHUSHKA.Models
{
    public class RegisterViewModel
    {
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public string FullName { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
