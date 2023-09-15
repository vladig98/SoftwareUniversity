using PhotoShare.Client.Core.Contracts;
using PhotoShare.Client.Core.Dtos;
using PhotoShare.Services.Contracts;
using System;

namespace PhotoShare.Client.Core.Commands
{
    public class LoginCommand : ICommand
    {
        private readonly IUserService userService;

        public LoginCommand(IUserService userService)
        {
            this.userService = userService;
        }


        public string Execute(string[] args)
        {
            var username = args[0];
            var password = args[1];

            var userExist = userService.Exists(username);

            if (!userExist)
            {
                throw new ArgumentException("Invalid username or password!");
            }

            var user = userService.ByUsername<UserDto>(username);

            if (user.Password != password)
            {
                throw new ArgumentException("Invalid username or password!");
            }

            if (user.LastTimeLoggedIn.HasValue)
            {
                throw new ArgumentException("You should logout first!");
            }

            userService.Login(username);

            return $"User {username} successfully logged in!";
        }
    }
}
