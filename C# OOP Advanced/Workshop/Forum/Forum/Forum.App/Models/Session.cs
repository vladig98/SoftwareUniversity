using Forum.App.Contracts.Models;
using Forum.Models;
using System.Collections.Generic;
using System.Linq;

namespace Forum.App.Models
{
    public class Session : ISession
    {
        private User user;
        private Stack<IMenu> history;

        public string Username => user?.Username;

        public int UserId => user?.Id ?? 0;

        public bool IsLoggedIn => user != null;

        public IMenu CurrentMenu => history.Count > 0 ? history.Peek() : null;

        public Session()
        {
            history = new Stack<IMenu>();
        }

        public IMenu Back()
        {
            if (history.Count > 1)
            {
                history.Pop();
            }

            IMenu previousMenu = history.Peek();
            previousMenu.Open();

            return previousMenu;
        }

        public void LogIn(User user)
        {
            this.user = user;
        }

        public void LogOut()
        {
            user = null;
        }

        public bool PushView(IMenu view)
        {
            if (history.Any())
            {
                if (history.Peek() != view)
                {
                    history.Push(view);
                    return true;
                }
            }

            return false;
        }

        public void Reset()
        {
            history = new Stack<IMenu>();
            user = null;
        }
    }
}
