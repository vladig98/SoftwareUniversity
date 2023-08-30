using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Logger.Loggers
{
    public class LogFile
    {
        public int Size { get; private set; }
        public StringBuilder stringBuilder;

        public void Write(string message)
        {
            stringBuilder.Append(message);
            Size += GetSize(message);
        }

        public LogFile()
        {
            Size = 0;
            stringBuilder = new StringBuilder();
        }

        private int GetSize(string message)
        {
            char[] chars = message.ToCharArray();

            //long way
            //int total = 0;

            //for (int i = 0; i < chars.Length; i++)
            //{
            //    if (Regex.IsMatch(chars[i].ToString(), @"[a-zA-Z]"))
            //    {
            //        total += chars[i];
            //    }
            //}

            //return total;

            //simple way using LINQ
            return chars.Where(x => Regex.IsMatch(x.ToString(), @"[a-zA-Z]")).Select(x => (int)x).ToList().Sum();
        }
    }
}
