using System;
using System.Collections.Generic;
using System.Text;

namespace Twitter
{
    public class Tweet : ITweet
    {
        public string Message { get; private set; }

        public void RetrieveMessage(string message)
        {
            Message = message;
        }
    }
}
