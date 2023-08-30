using System;

namespace Twitter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();

            string message = Console.ReadLine();

            Tweet tweet = new Tweet();

            tweet.RetrieveMessage(message);

            Client client = new Client();

            client.ReceiveTweet(tweet);
            client.PrintTweet();
            client.SendTweetToServer(server);
        }
    }
}
