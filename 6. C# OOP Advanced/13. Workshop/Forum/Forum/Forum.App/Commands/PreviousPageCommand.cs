﻿using Forum.App.Contracts.Menus;
using Forum.App.Contracts.Models;
using System;

namespace Forum.App.Commands
{
    public class PreviousPageCommand : ICommand
    {
        private ISession session;

        public PreviousPageCommand(ISession session)
        {
            this.session = session;
        }

        public IMenu Execute(params string[] args)
        {
            IMenu currentMenu = session.CurrentMenu;

            if (currentMenu is IPaginatedMenu paginatedMenu)
            {
                paginatedMenu.ChangePage(false);
            }

            return currentMenu;
        }
    }
}
