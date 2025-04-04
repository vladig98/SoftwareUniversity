﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace PhotoShare.Client.Core.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    internal class PasswordAttribute : ValidationAttribute
    {
        private const string SpecialSymbols = "!@#$%^&*()_+<>,.?";
        private int minLength;
        private int maxLength;

        public PasswordAttribute(int minLength, int maxLength)
        {
            this.minLength = minLength;
            this.maxLength = maxLength;
        }

        public override bool IsValid(object value)
        {
            string password = value.ToString();

            if (password.Length < this.minLength || password.Length > this.maxLength)
            {
                return false;
            }

            if (!password.Any(c => char.IsLower(c)))
            {
                return false;
            }

            //if (!password.Any(c => char.IsUpper(c)))
            //{
            //    return false;
            //}

            if (!password.Any(c => char.IsDigit(c)))
            {
                return false;
            }

            if (password.Any(c => SpecialSymbols.Contains(c)))
            {
                return false;
            }

            return true;
        }
    }
}
