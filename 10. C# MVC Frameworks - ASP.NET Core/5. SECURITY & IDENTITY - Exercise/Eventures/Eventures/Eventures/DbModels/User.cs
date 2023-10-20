using Eventures.DbModels.Enums;
using Microsoft.AspNetCore.Identity;

namespace Eventures.DbModels
{
    public class User : IdentityUser<string>
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public override string Id { get; set; }
        public override string? UserName { get; set; }
        public override string? Email { get; set; }
        public override string? PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UCN { get; set; }
        public Role Role { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
