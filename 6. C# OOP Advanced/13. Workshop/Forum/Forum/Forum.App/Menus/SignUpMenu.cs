﻿using Forum.App.Contracts.Factories;
using Forum.App.Contracts.Models;
using Forum.App.Models;
using System;

namespace Forum.App.Menus
{
    public class SignUpMenu : Menu
    {
        private const string DETAILS_ERROR = "Invalid Username or Password!";
        private const string USERNAME_TAKEN_ERROR = "Username already in use!";

        private bool error;

        private ILabelFactory labelFactory;
        private ICommandFactory commandFactory;
        private IForumReader forumReader;

        public SignUpMenu(ILabelFactory labelFactory, ICommandFactory commandFactory, IForumReader forumReader)
        {
            this.labelFactory = labelFactory;
            this.commandFactory = commandFactory;
            this.forumReader = forumReader;

            Open();
        }

        //TODO: Inject Dependencies

        private string UsernameInput => this.Buttons[0].Text.TrimStart();

        private string PasswordInput => this.Buttons[1].Text.TrimStart();

        private string ErrorMessage { get; set; }

        protected override void InitializeStaticLabels(Position consoleCenter)
        {
            string[] labelContents = new string[] { this.ErrorMessage, "Name:", "Password:" };

            Position[] labelPositions = new Position[]
            {
                new Position(consoleCenter.Left - this.ErrorMessage?.Length / 2 ?? 0, consoleCenter.Top - 13),   // Error: 
                new Position(consoleCenter.Left - 16, consoleCenter.Top - 10),   // Name:
                new Position(consoleCenter.Left - 16, consoleCenter.Top - 8),    // Password:
            };

            this.Labels = new ILabel[labelContents.Length];

            this.Labels[0] = new Forum.App.Models.Label(labelContents[0], labelPositions[0], !this.error);

            for (int i = 1; i < this.Labels.Length; i++)
            {
                this.Labels[i] = new Forum.App.Models.Label(labelContents[i], labelPositions[i]);
            }
        }

        protected override void InitializeButtons(Position consoleCenter)
        {
            string[] buttonContents = new string[]
            {
                " ", " ", "Sign Up", "Back"
            };

            Position[] buttonPositions = new Position[]
            {
                new Position(consoleCenter.Left - 10, consoleCenter.Top - 10), // Name
                new Position(consoleCenter.Left - 6, consoleCenter.Top - 8),   // Password
                new Position(consoleCenter.Left + 16, consoleCenter.Top),      // Sign Up
                new Position(consoleCenter.Left + 16, consoleCenter.Top + 1)   // Back
            };

            this.Buttons = new IButton[buttonContents.Length];

            for (int i = 0; i < this.Buttons.Length; i++)
            {
                string buttonContent = buttonContents[i];
                bool isField = string.IsNullOrWhiteSpace(buttonContent);
                this.Buttons[i] = this.labelFactory.CreateButton(buttonContent, buttonPositions[i], false, isField);
            }
        }

        public override IMenu ExecuteCommand()
        {
            if (CurrentOption.IsField)
            {
                string fieldInput = " " + forumReader.ReadLine(CurrentOption.Position.Left + 1, CurrentOption.Position.Top);

                Buttons[currentIndex] = labelFactory.CreateButton(fieldInput, CurrentOption.Position, CurrentOption.IsHidden, CurrentOption.IsField);

                return this;
            }

            try
            {
                string commandName = string.Join("", CurrentOption.Text.Split());
                ICommand command = commandFactory.CreateCommand(commandName);
                IMenu view = command.Execute(UsernameInput, PasswordInput);

                return view;
            }
            catch (Exception e)
            {
                error = true;
                ErrorMessage = e.Message;
                Open();
                return this;
            }
        }
    }
}
