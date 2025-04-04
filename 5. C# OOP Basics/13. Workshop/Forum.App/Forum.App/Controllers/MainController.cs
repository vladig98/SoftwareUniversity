﻿using Forum.App.Controllers.Contracts;
using Forum.App.UserInterface.Contracts;
using Forum.App.UserInterface.Views;

namespace Forum.App.Controllers
{
    public class MainController : IController, IUserRestrictedController
    {
        private const int COMMAND_COUNT = 3;

        public MainController()
        {
            this.LoggedInUser = false;
        }

        public bool LoggedInUser { get; private set; }

        public IView GetView(string userName)
        {
            return new MainView(userName);
        }

        public MenuState ExecuteCommand(int index)
        {
            if (LoggedInUser)
            {
                switch ((UserCommand)index)
                {
                    case UserCommand.Categories:
                        return MenuState.Categories;
                    case UserCommand.AddPost:
                        return MenuState.AddPost;
                    case UserCommand.LogOut:
                        return MenuState.LoggedOut;
                }
            }

            switch ((GuestCommand)index)
            {
                case GuestCommand.Categories:
                    return MenuState.Categories;
                case GuestCommand.Login:
                    return MenuState.Login;
                case GuestCommand.SignUp:
                    return MenuState.Signup;
            }

            throw new InvalidCommandException();
        }

        public void UserLogIn()
        {
            this.LoggedInUser = true;
        }

        public void UserLogOut()
        {
            this.LoggedInUser = false;
        }

        private enum GuestCommand
        {
            Categories, Login, SignUp
        }

        private enum UserCommand
        {
            Categories, AddPost, LogOut
        }
    }
}
