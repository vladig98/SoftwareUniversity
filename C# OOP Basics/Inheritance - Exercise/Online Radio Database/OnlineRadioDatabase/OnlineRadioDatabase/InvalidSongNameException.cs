using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase
{
    public class InvalidSongNameException : Exception
    {
        public InvalidSongNameException()
        {

        }

        public InvalidSongNameException(string message) : base(message)
        {

        }

        public InvalidSongNameException(string message, Exception exception) : base(message, exception)
        {

        }
    }
}
