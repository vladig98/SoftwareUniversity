using AutoMapper;
using Eventures.Data;
using Eventures.DbModels;
using Eventures.DbModels.Enums;
using Eventures.Models;
using Eventures.Services.Contracts;
using Microsoft.AspNetCore.Identity;

namespace Eventures.Services
{
    public class UsersService : IUsersService
    {
        private readonly EventuresDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public UsersService(EventuresDbContext context, UserManager<User> userManager, IMapper mapper)
        {
            _context = context;
            _userManager = userManager;
            _mapper = mapper;
        }

        public bool HasMoreThanOneAdmin() => _context.Users.Where(x => x.Role == Role.Admin).Count() > 1;
        public IQueryable<User> GetUsers() => _context.Users;

        public User CreateUserInstance(ExternalLoginViewModel model)
        {
            var user = _mapper.Map<ExternalLoginViewModel, User>(model);

            return user;
        }

        public User CreateUserInstance(RegisterViewModel model)
        {
            var user = _mapper.Map<RegisterViewModel, User>(model);

            return user;
        }

        public async Task Promote(User user)
        {
            user.Role = Role.Admin;
            await _userManager.RemoveFromRoleAsync(user, Role.User.ToString());
            await _userManager.AddToRoleAsync(user, Role.Admin.ToString());

            _context.SaveChanges();
        }

        public async Task Demote(User user)
        {
            user.Role = Role.User;
            await _userManager.RemoveFromRoleAsync(user, Role.Admin.ToString());
            await _userManager.AddToRoleAsync(user, Role.User.ToString());

            _context.SaveChanges();
        }
    }
}
