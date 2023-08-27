using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase
{
    public class InvalidSongLengthException : Exception
    {
        public InvalidSongLengthException()
        {

        }

        public InvalidSongLengthException(string message) : base(message)
        {

        }

        public InvalidSongLengthException(string message, Exception exception) : base(message, exception)
        {

        }
    }
}
