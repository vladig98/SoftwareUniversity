using BWCommandStrikeBack.Contracts;
using BWCommandStrikeBack.Core;
using BWCommandStrikeBack.Core.Factories;
using BWCommandStrikeBack.Data;

namespace BWCommandStrikeBack
{
    class AppEntryPoint
    {
        static void Main(string[] args)
        {
            IRepository repository = new UnitRepository();
            IUnitFactory unitFactory = new UnitFactory();
            IRunnable engine = new Engine(repository, unitFactory);
            engine.Run();
        }
    }
}
