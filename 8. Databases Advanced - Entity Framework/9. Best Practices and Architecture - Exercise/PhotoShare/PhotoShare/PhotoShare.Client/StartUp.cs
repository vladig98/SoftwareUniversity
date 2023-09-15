using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PhotoShare.Client.Core;
using PhotoShare.Client.Core.Contracts;
using PhotoShare.Data;
using PhotoShare.Services;
using PhotoShare.Services.Contracts;
using System;
using System.IO;

namespace PhotoShare.Client
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var service = ConfigureServices();
            Engine engine = new Engine(service);
            engine.Run();
        }

        private static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..")))
                .AddJsonFile("appsettings.json")
                .Build();

            serviceCollection.AddDbContext<PhotoShareContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            serviceCollection.AddAutoMapper(cfg => cfg.AddProfile<PhotoShareProfile>());

            serviceCollection.AddTransient<ICommandInterpreter, CommandInterpreter>();
            serviceCollection.AddTransient<IDatabaseInitializerService, DatabaseInitializerService>();

            serviceCollection.AddTransient<IAlbumRoleService, AlbumRoleService>();
            serviceCollection.AddTransient<IAlbumService, AlbumService>();
            serviceCollection.AddTransient<IAlbumTagService, AlbumTagService>();
            serviceCollection.AddTransient<IPictureService, PictureService>();
            serviceCollection.AddTransient<ITagService, TagService>();
            serviceCollection.AddTransient<ITownService, TownService>();
            serviceCollection.AddTransient<IUserService, UserService>();


            var serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
