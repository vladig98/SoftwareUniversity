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

        public override bool Equals(object? obj)
        {
            var user = obj as User;

            if (user.UCN != UCN)
            {
                return false;
            }

            if (user.Email != Email)
            {
                return false;
            }

            if (user.FirstName != FirstName)
            {
                return false;
            }

            if (user.LastName != LastName)
            {
                return false;
            }

            if (user.Role != Role)
            {
                return false;
            }

            if (user.Id != Id)
            {
                return false;
            }

            if (user.UserName != UserName)
            {
                return false;
            }

            if (user.PasswordHash != PasswordHash)
            {
                return false;
            }

            return true;
        }
    }
}
