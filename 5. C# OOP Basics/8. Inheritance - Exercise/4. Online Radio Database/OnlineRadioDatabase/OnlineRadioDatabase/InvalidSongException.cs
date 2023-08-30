using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase
{
    public class InvalidSongException : Exception
    {
        public InvalidSongException()
        {
            
        }

        public InvalidSongException(string message):base(message)
        {
            
        }

        public InvalidSongException(string message, Exception exception):base(message, exception)
        {
            
        }
    }
}
