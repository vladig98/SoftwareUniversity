﻿using System;
using System.Linq;
using TeamBuilder.App.Utilities;
using TeamBuilder.Data;
using TeamBuilder.Models;
using TeamBuilder.Models.Enums;

namespace TeamBuilder.App.Core.Commands
{
    public class RegisterUserCommand
    {
        public string Execute(string[] inputArgs)
        {
            Check.CheckLength(7, inputArgs);

            string username = inputArgs[0];

            if (username.Length < Constants.MinUsernameLength || username.Length > Constants.MaxUsernameLength)
            {
                throw new ArgumentException(string.Format(Constants.ErrorMessages.UsernameNotValid, username));
            }

            string password = inputArgs[1];

            if (!password.Any(char.IsDigit) || !password.Any(char.IsUpper))
            {
                throw new ArgumentException(string.Format(Constants.ErrorMessages.PasswordNotValid, password));
            }

            string repeatedPassword = inputArgs[2];

            if (password != repeatedPassword)
            {
                throw new InvalidOperationException(Constants.ErrorMessages.PasswordDoesNotMatch);
            }

            string firstName = inputArgs[3];
            string lastName = inputArgs[4];

            int age;
            bool isNumber = int.TryParse(inputArgs[5], out age);

            if (!isNumber || age <= 0)
            {
                throw new ArgumentException(Constants.ErrorMessages.AgeNotValid);
            }

            Gender gender;
            bool isGenderValid = Enum.TryParse(inputArgs[6], out gender);

            if (!isGenderValid)
            {
                throw new ArgumentException(Constants.ErrorMessages.GenderNotValid);
            }

            if (CommandHelper.IsUserExisting(username))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.UsernameIsTaken, username));
            }

            RegisterUser(username, password, firstName, lastName, age, gender);

            return $"User {username} was registered successfully!";
        }

        private void RegisterUser(string username, string password, string firstName, string lastName, int age, Gender gender)
        {
            using (TeamBuilderContext context = new TeamBuilderContext())
            {
                User user = new User
                {
                    Username = username,
                    Password = password,
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    Gender = gender
                };

                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
