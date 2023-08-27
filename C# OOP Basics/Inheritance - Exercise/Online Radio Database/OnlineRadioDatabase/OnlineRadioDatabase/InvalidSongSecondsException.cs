using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase
{
    public class InvalidSongSecondsException : Exception
    {
        public InvalidSongSecondsException()
        {

        }

        public InvalidSongSecondsException(string message) : base(message)
        {

        }

        public InvalidSongSecondsException(string message, Exception exception) : base(message, exception)
        {

        }
    }
}
