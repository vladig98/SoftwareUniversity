using System;

namespace Telephony
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ");
            string[] websites = Console.ReadLine().Split(" ");

            Smartphone phone = new Smartphone();

            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                phone.CallNumber(phoneNumbers[i]);
            }

            for (int i = 0; i < websites.Length; i++)
            {
                phone.BrowseWebsite(websites[i]);
            }
        }
    }
}
