using PhotoShare.Client.Core.Contracts;
using PhotoShare.Client.Core.Dtos;
using PhotoShare.Services.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PhotoShare.Client.Core.Commands
{
    public class RegisterUserCommand : ICommand
    {
        private readonly IUserService service;

        public RegisterUserCommand(IUserService service)
        {
            this.service = service;
        }

        // RegisterUser <username> <password> <repeat-password> <email>
        public string Execute(string[] data)
        {
            if (data.Length != 4)
            {
                return "Invalid data.";
            }

            var username = data[0];
            var password = data[1];
            var repatedPassword = data[2];
            var email = data[3];

            var userDto = new RegisterUserDto
            {
                Username = username,
                Password = password,
                Email = email
            };

            var valid = IsValid(userDto);

            if (!valid)
            {
                throw new ArgumentException("Invalid data!");
            }

            if (service.Exists(username))
            {
                throw new InvalidOperationException($"Username {username} is already taken!");
            }

            if (password != repatedPassword)
            {
                throw new ArgumentException($"Passwords do not match!");
            }

            service.Register(username, password, email);

            return $"User {username} was registered successfully!";
        }

        private bool IsValid(object obj)
        {
            var validationContext = new ValidationContext(obj);
            var validationResults = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, validationContext, validationResults, true);
        }
    }
}
