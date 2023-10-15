using Eventures.Data;
using Eventures.DbModels;
using Eventures.DbModels.Enums;
using Microsoft.AspNetCore.Identity;

namespace Eventures.Middleware
{
    public class DataSeeder
    {
        private readonly RequestDelegate _next;

        public DataSeeder(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, EventuresDbContext _context,
            RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            if (!_context.Roles.Any())
            {
                await SeedRoles(roleManager);
            }

            if (!_context.Users.Any())
            {
                await SeedUsers(userManager);
            }

            await _next(context);
        }

        private async Task SeedUsers(UserManager<User> _userManager)
        {
            var user = new User()
            {
                UserName = "Vladi",
                Email = "vladi.gocin@gmail.com",
                Id = Guid.NewGuid().ToString(),
                FirstName = "Vladi",
                LastName = "Gotsin",
                UCN = "12345",
                Role = Role.Admin
            };

            var userCreated = await _userManager.CreateAsync(user, "123");
            var userAddedToRole = await _userManager.AddToRoleAsync(user, Role.Admin.ToString());
        }

        private async Task SeedRoles(RoleManager<IdentityRole> _roleManager)
        {
            foreach (var item in Enum.GetValues(typeof(Role)))
            {
                var role = new IdentityRole(item.ToString());

                var roleCreated = await _roleManager.CreateAsync(role);
            }
        }
    }
}
