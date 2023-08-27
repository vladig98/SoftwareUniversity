using System;

namespace Forum.App
{
    public class InvalidCommandException : Exception
    {
        public override string Message => "Invalid command!";
    }
}
