using Forum.App.Contracts;
using Forum.App.Contracts.Factories;
using Forum.App.Contracts.Models;
using Forum.App.Menus;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace Forum.App
{
    public class MenuController : IMainController
    {
        private IServiceProvider serviceProvider;

        private IForumViewEngine viewEngine;
        private ISession session;
        private ICommandFactory commandFactory;

        public MenuController(IServiceProvider serviceProvider, IForumViewEngine viewEngine, ISession session, ICommandFactory commandFactory)
        {
            this.serviceProvider = serviceProvider;
            this.viewEngine = viewEngine;
            this.session = session;
            this.commandFactory = commandFactory;

            InitializeSession();
        }

        private string Username { get; set; }

        //Replace CurrentMenu with this after implementing Session
        private IMenu CurrentMenu => this.session.CurrentMenu;

        //private IMenu CurrentMenu { get; }

        private void InitializeSession()
        {
            this.session.PushView(new MainMenu(this.session,
                this.serviceProvider.GetService<ILabelFactory>(),
                this.serviceProvider.GetService<ICommandFactory>()));

            this.RenderCurrentView();
        }

        private void RenderCurrentView()
        {
            this.viewEngine.RenderMenu(this.CurrentMenu);
        }

        public void MarkOption()
        {
            if (viewEngine == null || CurrentMenu == null)
            {
                return;
            }

            this.viewEngine.Mark(this.CurrentMenu.CurrentOption);
        }

        public void UnmarkOption()
        {
            if (viewEngine == null || CurrentMenu == null)
            {
                return;
            }

            this.viewEngine.Mark(this.CurrentMenu.CurrentOption, false);
        }

        public void NextOption()
        {
            this.CurrentMenu.NextOption();
        }

        public void PreviousOption()
        {
            this.CurrentMenu.PreviousOption();
        }

        public void Back()
        {
            this.session.Back();
            RenderCurrentView();
        }

        public void Execute()
        {
            if (CurrentMenu == null)
            {
                return;
            }

            this.session.PushView(this.CurrentMenu.ExecuteCommand());
            this.RenderCurrentView();
        }
    }
}
