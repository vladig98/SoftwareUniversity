using System;
using System.Collections.Generic;
using System.Text;

namespace Twitter
{
    public class Client : IClient
    {
        public Tweet Tweet { get; private set; }

        public void PrintTweet()
        {
            Console.WriteLine(Tweet.Message);
        }

        public void ReceiveTweet(Tweet tweet)
        {
            Tweet = tweet;
        }

        public void SendTweetToServer(Server server)
        {
            server.SaveTweet(Tweet);
            Console.WriteLine("Tweet saved to the server!");
        }
    }
}
