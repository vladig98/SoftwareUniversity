using Forum.App.Contracts.Factories;
using Forum.App.Contracts.Models;
using System;

namespace Forum.App.Commands
{
    public class LogOutCommand : ICommand
    {
        private ISession session;
        private IMenuFactory menuFactory;

        public LogOutCommand(ISession session, IMenuFactory menuFactory)
        {
            this.session = session;
            this.menuFactory = menuFactory;
        }

        public IMenu Execute(params string[] args)
        {
            session.Reset();

            return menuFactory.CreateMenu("MainMenu");
        }
    }
}
