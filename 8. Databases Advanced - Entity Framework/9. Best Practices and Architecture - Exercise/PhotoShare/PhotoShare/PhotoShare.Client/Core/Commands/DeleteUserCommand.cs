using PhotoShare.Client.Core.Contracts;
using PhotoShare.Client.Core.Dtos;
using PhotoShare.Services.Contracts;
using System;

namespace PhotoShare.Client.Core.Commands
{
    public class DeleteUserCommand : ICommand
    {
        private readonly IUserService userService;

        public DeleteUserCommand(IUserService userService)
        {
            this.userService = userService;
        }

        // DeleteUser <username>
        public string Execute(string[] data)
        {
            if (data.Length != 1)
            {
                return "Invalid data.";
            }

            string username = data[0];

            var userExists = this.userService.Exists(username);

            if (!userExists)
            {
                throw new ArgumentException($"User {username} not found!");
            }

            var user = userService.ByUsername<UserDto>(username);

            if (!user.LastTimeLoggedIn.HasValue)
            {
                return "Invalid credentials!";
            }

            userService.Delete(username);


            return $"User {username} was deleted from the database!";
        }
    }
}
