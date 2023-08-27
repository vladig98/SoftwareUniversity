using Forum.App.Contracts.Factories;
using Forum.App.Contracts.Menus;
using Forum.App.Contracts.Models;

namespace Forum.App.Commands
{
    public class ViewPostMenuCommand : ICommand
    {
        private IMenuFactory menuFactory;

        public ViewPostMenuCommand(IMenuFactory menuFactory)
        {
            this.menuFactory = menuFactory;
        }

        public IMenu Execute(params string[] args)
        {
            int postId = int.Parse(args[0]);

            string commandName = this.GetType().Name;
            string menuName = commandName.Substring(0, commandName.Length - "Command".Length);

            IIdHoldingMenu menu = (IIdHoldingMenu)menuFactory.CreateMenu(menuName);
            menu.SetId(postId);

            return menu;
        }
    }
}
