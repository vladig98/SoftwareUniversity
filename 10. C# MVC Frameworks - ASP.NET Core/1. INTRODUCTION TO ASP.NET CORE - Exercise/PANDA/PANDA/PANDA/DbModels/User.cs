using Microsoft.AspNetCore.Identity;
using PANDA.DbModels.Enums;

namespace PANDA.DbModels
{
    public class User : IdentityUser<string>
    {
        public User()
        {
            Receipts = new HashSet<Receipt>();
            Packages = new HashSet<Package>();
        }

        public User(string userName) : base(userName)
        {
        }

        //public string Id { get; set; }

        public override string? UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
        public ICollection<Receipt> Receipts { get; set; }
        public ICollection<Package> Packages { get; set; }
    }
}
