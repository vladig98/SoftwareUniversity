using BWReturnDependency.Contracts;
using BWReturnDependency.Core;
using BWReturnDependency.Core.Factories;
using BWReturnDependency.Data;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BWReturnDependency
{
    class AppEntryPoint
    {
        static void Main(string[] args)
        {
            //IRepository repository = new UnitRepository();
            //IUnitFactory unitFactory = new UnitFactory();

            IServiceProvider serviceProvider = ConfigureService();

            IRunnable engine = new Engine(/*repository, unitFactory*/serviceProvider);
            engine.Run();
        }

        private static IServiceProvider ConfigureService()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddTransient<IUnitFactory, UnitFactory>();
            services.AddSingleton<IRepository, UnitRepository>();

            IServiceProvider serviceProvider = services.BuildServiceProvider();
            return serviceProvider;
        }
    }
}
