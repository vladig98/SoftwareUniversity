using System;
using System.Collections.Generic;
using System.Text;

namespace Twitter
{
    public class Server
    {
        public List<Tweet> Tweets {  get; private set; }

        public Server()
        {
            Tweets = new List<Tweet>();
        }

        public void SaveTweet(Tweet tweet)
        {
            Tweets.Add(tweet);
        }
    }
}
