using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase
{
    public class InvalidSongMinutesException : Exception
    {
        public InvalidSongMinutesException()
        {

        }

        public InvalidSongMinutesException(string message) : base(message)
        {

        }

        public InvalidSongMinutesException(string message, Exception exception) : base(message, exception)
        {

        }
    }
}
