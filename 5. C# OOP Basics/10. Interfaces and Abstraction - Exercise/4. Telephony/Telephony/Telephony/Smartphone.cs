using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Telephony
{
    public class Smartphone : ICallNumbers, IBrowseWeb
    {
        public void CallNumber(string phoneNumber)
        {
            if (!Regex.IsMatch(phoneNumber, @"\d+"))
            {
                Console.WriteLine("Invalid number!");
                return;
            }
            Console.WriteLine($"Calling... {phoneNumber}");
        }

        public void BrowseWebsite(string website)
        {
            if (website.ToCharArray().Any(x => Regex.IsMatch(x.ToString(), @"\d+")))
            {
                Console.WriteLine("Invalid URL!");
                return;
            }
            Console.WriteLine($"Browsing: {website}!");
        }

        public Smartphone()
        {
            
        }
    }
}
