using PhotoShare.Client.Core.Contracts;
using PhotoShare.Services.Contracts;
using System;
using System.Linq;

namespace PhotoShare.Client.Core.Commands
{
    public class LogoutCommand : ICommand
    {
        private readonly IUserService userService;

        public LogoutCommand(IUserService userService)
        {
            this.userService = userService;
        }

        public string Execute(string[] args)
        {
            var users = userService.GetAllUsers();

            if (!users.Where(x => x.LastTimeLoggedIn.HasValue).Any())
            {
                throw new InvalidOperationException("You should log in first in order to logout.");
            }

            var user = users.FirstOrDefault(x => x.LastTimeLoggedIn.HasValue);

            userService.Logout(user.Username);

            return $"User {user.Username} successfully logged out!";
        }
    }
}
