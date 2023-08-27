using System;
using System.Collections.Generic;
using System.Text;

namespace Twitter
{
    public interface IClient
    {
        public Tweet Tweet { get; }
        public void ReceiveTweet(Tweet tweet);
        public void PrintTweet();
        public void SendTweetToServer(Server server);
    }
}
