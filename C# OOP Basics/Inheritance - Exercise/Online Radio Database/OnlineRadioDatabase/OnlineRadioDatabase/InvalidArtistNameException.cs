using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase
{
    public class InvalidArtistNameException : Exception
    {
        public InvalidArtistNameException()
        {

        }

        public InvalidArtistNameException(string message) : base(message)
        {

        }

        public InvalidArtistNameException(string message, Exception exception) : base(message, exception)
        {

        }
    }
}
