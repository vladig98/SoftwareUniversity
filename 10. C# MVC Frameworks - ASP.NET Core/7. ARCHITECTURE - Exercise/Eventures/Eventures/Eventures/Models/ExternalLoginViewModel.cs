using Eventures.DbModels.Enums;
using System.ComponentModel.DataAnnotations;

namespace Eventures.Models
{
    public class ExternalLoginViewModel
    {
        public ExternalLoginViewModel()
        {
            Id = Guid.NewGuid().ToString();
            Role = Role.User;
        }

        public string ProviderDisplayName { get; set; }
        public string ReturnUrl { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UCN { get; set; }
        public string Id { get; set; }
        public Role Role { get; set; }
    }
}
