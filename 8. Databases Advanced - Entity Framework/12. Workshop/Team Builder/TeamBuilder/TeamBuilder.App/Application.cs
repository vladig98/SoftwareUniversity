using TeamBuilder.App.Core;

namespace TeamBuilder.App
{
    public class Application
    {
        public static void Main(string[] args)
        {
            Engine engine = new Engine(new CommandDispatcher());
            engine.Run();
        }
    }
}
