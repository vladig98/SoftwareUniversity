﻿using Forum.App.Contracts.Factories;
using Forum.App.Contracts.Menus;
using Forum.App.Contracts.Models;
using System;

namespace Forum.App.Commands
{
    public class ViewCategoryMenuCommand : ICommand
    {
        private IMenuFactory menuFactory;

        public ViewCategoryMenuCommand(IMenuFactory menuFactory)
        {
            this.menuFactory = menuFactory;
        }

        public IMenu Execute(params string[] args)
        {
            int categoryId = int.Parse(args[0]);

            string commandName = this.GetType().Name;
            string menuName = commandName.Substring(0, commandName.Length - "Command".Length);

            IIdHoldingMenu menu = (IIdHoldingMenu)menuFactory.CreateMenu(menuName);
            menu.SetId(categoryId);

            return menu;
        }
    }
}
