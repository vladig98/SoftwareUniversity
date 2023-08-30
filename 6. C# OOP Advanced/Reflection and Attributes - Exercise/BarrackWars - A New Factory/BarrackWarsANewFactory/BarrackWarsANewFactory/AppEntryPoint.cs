using BarrackWarsANewFactory.Contracts;
using BarrackWarsANewFactory.Core;
using BarrackWarsANewFactory.Core.Factories;
using BarrackWarsANewFactory.Data;

namespace BarrackWarsANewFactory
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
