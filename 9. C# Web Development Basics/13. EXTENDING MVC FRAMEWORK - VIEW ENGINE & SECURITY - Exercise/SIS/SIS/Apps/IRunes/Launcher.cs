using SIS.Framework;

namespace IRunes
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            WebHost.Start(new StartUp());
        }
    }
}
