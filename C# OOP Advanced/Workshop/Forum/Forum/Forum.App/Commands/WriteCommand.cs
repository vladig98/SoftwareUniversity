using Forum.App.Contracts.Menus;
using Forum.App.Contracts.Models;
using System;

namespace Forum.App.Commands
{
    public class WriteCommand : ICommand
    {
        private ISession session;

        public WriteCommand(ISession session)
        {
            this.session = session;
        }

        public IMenu Execute(params string[] args)
        {
            ITextAreaMenu currentMenu = (ITextAreaMenu)session.CurrentMenu;
            currentMenu.TextArea.Write();

            return currentMenu;
        }
    }
}
