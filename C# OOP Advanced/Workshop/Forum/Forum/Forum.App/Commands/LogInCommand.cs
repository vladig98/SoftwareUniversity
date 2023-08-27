﻿using Forum.App.Contracts.Factories;
using Forum.App.Contracts.Models;
using Forum.App.Contracts.Services;
using System;

namespace Forum.App.Commands
{
    public class LogInCommand : ICommand
    {
        private IUserService userService;
        private IMenuFactory menuFactory;

        public LogInCommand(IUserService userService, IMenuFactory menuFactory)
        {
            this.userService = userService;
            this.menuFactory = menuFactory;
        }

        public IMenu Execute(params string[] args)
        {
            string username = args[0];
            string password = args[1];

            bool success = userService.TryLogInUser(username, password);

            if (!success)
            {
                throw new InvalidOperationException("Invalid credentials!");
            }

            return menuFactory.CreateMenu("MainMenu");
        }
    }
}
