using InfernoInfinityBonus.Contracts;
using InfernoInfinityBonus.Core;
using InfernoInfinityBonus.Core.Factories;
using InfernoInfinityBonus.Data;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace InfernoInfinityBonus
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IServiceProvider serviceProvider = ConfigureService();

            Engine engine = new Engine(serviceProvider);
            engine.Run();
        }

        private static IServiceProvider ConfigureService()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddTransient<IWeaponFactory, WeaponFactory>();
            services.AddSingleton<IRepository, WeaponRepository>();

            IServiceProvider serviceProvider = services.BuildServiceProvider();
            return serviceProvider;
        }
    }
}
