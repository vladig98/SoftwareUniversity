using Forum.App.Contracts.Factories;
using Forum.App.Contracts.Models;

namespace Forum.App.Commands
{
    public class LogInMenuCommand : ICommand
    {
        private IMenuFactory menuFactory;

        public LogInMenuCommand(IMenuFactory menuFactory)
        {
            this.menuFactory = menuFactory;
        }

        public IMenu Execute(params string[] args)
        {
            string commandName = this.GetType().Name;
            string menuName = commandName.Substring(0, commandName.Length - "Command".Length);

            IMenu menu = menuFactory.CreateMenu(menuName);
            return menu;
        }
    }
}
