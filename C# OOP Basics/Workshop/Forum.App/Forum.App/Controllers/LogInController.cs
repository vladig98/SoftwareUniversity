using System;
using Forum.App.Controllers.Contracts;
using Forum.App.Services;
using Forum.App.UserInterface;
using Forum.App.UserInterface.Contracts;
using Forum.App.UserInterface.Views;

namespace Forum.App.Controllers
{
    public class LogInController : IController, IReadUserInfoController
    {
        public string Username { get; private set; }
        private string Password { get; set; }
        private bool Error { get; set; }

        public MenuState ExecuteCommand(int index)
        {
            switch ((Command)index)
            {
                case Command.Back:
                    ResetLogin();
                    return MenuState.Back;
                case Command.LogIn:
                    bool loggedIn = UserService.TryLogInUser(Username, Password);
                    if (loggedIn)
                    {
                        return MenuState.SuccessfulLogIn;
                    }

                    Error = true;
                    return MenuState.Error;
                case Command.ReadPassword:
                    ReadPassword();
                    return MenuState.Login;
                case Command.ReadUsername:
                    ReadUsername();
                    return MenuState.Login;
            }

            throw new InvalidOperationException();
        }

        public IView GetView(string userName)
        {
            return new LogInView(Error, Username, Password.Length);
        }

        public void ReadPassword()
        {
            Password = ForumViewEngine.ReadRow();
            ForumViewEngine.HideCursor();
        }

        public void ReadUsername()
        {
            Username = ForumViewEngine.ReadRow();
            ForumViewEngine.HideCursor();
        }

        private enum Command
        {
            ReadUsername, ReadPassword, LogIn, Back
        }

        private void ResetLogin()
        {
            Error = false;
            Username = string.Empty;
            Password = string.Empty;
        }

        public LogInController()
        {
            ResetLogin();
        }
    }
}
