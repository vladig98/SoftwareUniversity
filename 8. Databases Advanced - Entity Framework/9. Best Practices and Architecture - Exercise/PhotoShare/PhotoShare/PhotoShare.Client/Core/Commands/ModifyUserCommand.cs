using PhotoShare.Client.Core.Contracts;
using PhotoShare.Client.Core.Dtos;
using PhotoShare.Models;
using PhotoShare.Services.Contracts;
using System;
using System.Linq;

namespace PhotoShare.Client.Core.Commands
{
    public class ModifyUserCommand : ICommand
    {
        private readonly IUserService userService;
        private readonly ITownService townService;

        public ModifyUserCommand(IUserService userService, ITownService townService)
        {
            this.userService = userService;
            this.townService = townService;
        }

        // ModifyUser <username> <property> <new value>
        // For example:
        // ModifyUser <username> Password <NewPassword>
        // ModifyUser <username> BornTown <newBornTownName>
        // ModifyUser <username> CurrentTown <newCurrentTownName>
        // !!! Cannot change username
        public string Execute(string[] data)
        {
            if (data.Length != 3)
            {
                return "Invalid data.";
            }

            var username = data[0];
            var property = data[1];
            var value = data[2];

            var userExists = userService.Exists(username);

            if (!userExists)
            {
                throw new ArgumentException($"User {username} not found!");
            }

            var user = userService.ByUsername<UserDto>(username);

            if (!user.LastTimeLoggedIn.HasValue)
            {
                return "Invalid credentials!";
            }

            if (property == "Password")
            {
                SetPassword(username, value);
            }
            else if (property == "BornTown")
            {
                SetBornTown(username, value);
            }
            else if (property == "CurrentTown")
            {
                SetCurrentTown(username, value);
            }
            else
            {
                throw new ArgumentException($"Property {property} not supported!");
            }

            return $"User {username} {property} is {value}.";
        }

        private void SetBornTown(string username, string townName)
        {
            var townExists = townService.Exists(townName);

            if (!townExists)
            {
                throw new ArgumentException($"Value {townName} not valid.\r\nTown {townName} not found!");
            }

            var userId = userService.ByUsername<UserDto>(username).Id;
            var townId = townService.ByName<TownDto>(townName).Id;

            userService.SetBornTown(userId, townId);
        }

        private void SetCurrentTown(string username, string townName)
        {
            var townExists = townService.Exists(townName);

            if (!townExists)
            {
                throw new ArgumentException($"Value {townName} not valid.\r\nTown {townName} not found!");
            }

            var userId = userService.ByUsername<UserDto>(username).Id;
            var townId = townService.ByName<TownDto>(townName).Id;

            userService.SetCurrentTown(userId, townId);
        }

        private void SetPassword(string usernmae, string password)
        {
            var isValid = password.Any(x => char.IsLower(x)) && password.Any(x => char.IsDigit(x));

            if (!isValid)
            {
                throw new ArgumentException($"Value {password} not valid.\r\nInvalid Password");
            }

            var userId = userService.ByUsername<UserDto>(usernmae).Id;

            userService.ChangePassword(userId, password);
        }
    }
}
