using CHUSHKA.DbModels.Enums;
using Microsoft.AspNetCore.Identity;

namespace CHUSHKA.DbModels
{
    public class User : IdentityUser<string>
    {
        public User()
        {
            Orders = new List<Order>();
        }

        public User(string userName) : base(userName)
        {
        }

        public override string? UserName { get; set; }

        //public string Id { get; set; }
        public string FullName { get; set; }
        public Role Role { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
