using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class EventLogger : Logger
    {
        public override void Handle(LogType type, string message)
        {
            switch (type)
            {
                case LogType.ERROR:
                    Console.WriteLine(type.ToString() + ": " + message);
                    break;
                case LogType.EVENT:
                    Console.WriteLine(type.ToString() + ": " + message);
                    break;
            }
        }
    }
}
