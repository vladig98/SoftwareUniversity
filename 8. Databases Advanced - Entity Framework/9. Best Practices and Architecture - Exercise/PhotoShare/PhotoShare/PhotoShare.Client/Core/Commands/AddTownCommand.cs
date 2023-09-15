using PhotoShare.Client.Core.Contracts;
using PhotoShare.Services.Contracts;
using System;
using System.Linq;

namespace PhotoShare.Client.Core.Commands
{
    public class AddTownCommand : ICommand
    {
        private readonly ITownService townService;
        private readonly IUserService userService;

        public AddTownCommand(ITownService townService, IUserService userService)
        {
            this.townService = townService;
            this.userService = userService;
        }

        // AddTown <townName> <countryName>
        public string Execute(string[] data)
        {
            var users = userService.GetAllUsers();

            if (!users.Where(x => x.LastTimeLoggedIn.HasValue).Any())
            {
                return "Invalid credentials!";
            }

            if (data.Length != 2)
            {
                return "Invalid data.";
            }

            string townName = data[0];
            string country = data[1];

            var townExists = this.townService.Exists(townName);

            if (townExists)
            {
                throw new ArgumentException($"Town {townName} was already added!");
            }

            var town = this.townService.Add(townName, country);

            return $"Town {townName} was added successfully!";
        }
    }
}
