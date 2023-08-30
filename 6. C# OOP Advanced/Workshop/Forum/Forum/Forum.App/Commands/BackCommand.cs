using Forum.App.Contracts.Models;
using System;

namespace Forum.App.Commands
{
    public class BackCommand : ICommand
    {
        private ISession session;

        public BackCommand(ISession session)
        {
            this.session = session;
        }

        public IMenu Execute(params string[] args)
        {
            IMenu menu = session.Back();
            return menu;
        }
    }
}
