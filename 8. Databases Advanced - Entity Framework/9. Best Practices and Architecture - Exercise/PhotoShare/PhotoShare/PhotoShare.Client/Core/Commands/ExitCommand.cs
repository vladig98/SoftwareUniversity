﻿using PhotoShare.Client.Core.Contracts;
using System;

namespace PhotoShare.Client.Core.Commands
{
    public class ExitCommand : ICommand
    {
        public string Execute(string[] data)
        {
            Environment.Exit(0);
            return "Bye-bye!";
        }
    }
}
