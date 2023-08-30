using NUnit.Framework;
using System;
using System.IO;
using Twitter;

namespace Tests
{
    public class Class1
    {
        [Test]
        public void TestRetrieveMessage()
        {
            Tweet tweet = new Tweet();

            tweet.RetrieveMessage("This is a unit test");

            Assert.That(tweet.Message, Is.EqualTo("This is a unit test"));
        }

        [Test]
        public void TestReceiveTweet()
        {
            Tweet tweet = new Tweet();
            tweet.RetrieveMessage("This is a unit test");

            Client client = new Client();
            client.ReceiveTweet(tweet);

            Assert.That(client.Tweet , Is.EqualTo(tweet));
        }

        [Test]
        public void TestPrintTweet()
        {
            Tweet tweet = new Tweet();
            tweet.RetrieveMessage("This is a unit test");

            Client client = new Client();
            client.ReceiveTweet(tweet);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            client.PrintTweet();

            var output = stringWriter.ToString();

            Assert.That(client.Tweet.Message, Is.EqualTo(output.Trim('\n').Trim('\r')));
        }

        [Test]
        public void TestSendTweetToServer()
        {
            Server server = new Server();

            Tweet tweet = new Tweet();
            tweet.RetrieveMessage("This is a unit test");

            Client client = new Client();
            client.ReceiveTweet(tweet);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            client.SendTweetToServer(server);

            var output = stringWriter.ToString();

            Assert.That("Tweet saved to the server!", Is.EqualTo(output.Trim('\n').Trim('\r')));
        }

        [Test]
        public void TestSavingTweets()
        {
            Server server = new Server();

            Tweet tweet = new Tweet();
            tweet.RetrieveMessage("This is a unit test");

            server.SaveTweet(tweet);

            Assert.That(server.Tweets.Count, Is.EqualTo(1));
        }
    }
}
