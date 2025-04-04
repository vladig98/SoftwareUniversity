﻿namespace PhotoShare.Client.Core.Commands
{
    using System;

    using Dtos;
    using Contracts;
    using Services.Contracts;

    public class DeleteUser : ICommand
    {
        private readonly IUserService userService;

        public DeleteUser(IUserService userService)
        {
            this.userService = userService;
        }

        // DeleteUser <username>
        public string Execute(string[] data)
        {
            string username = data[1];

            var userExists = this.userService.Exists(username);

            if (!userExists)
            {
                throw new ArgumentException($"User {username} not found!");
            }

            var user = this.userService.ByUsername<UserDto>(username);


            return $"User {username} was deleted from the database!";
        }
    }
}
