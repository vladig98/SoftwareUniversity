﻿using PhotoShare.Client.Core.Validation;

namespace PhotoShare.Client.Core.Dtos
{
    public class RegisterUserDto
    {
        public string Username { get; set; }

        [Password(4, 20)]
        public string Password { get; set; }

        //public string RepeatPassword { get; set; }

        [Email]
        public string Email { get; set; }
    }
}
