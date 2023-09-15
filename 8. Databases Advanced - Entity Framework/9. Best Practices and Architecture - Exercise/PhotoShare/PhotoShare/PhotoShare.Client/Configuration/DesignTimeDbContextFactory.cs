using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PhotoShare.Data;
using System.IO;

namespace PhotoShare.Client.Configuration
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<PhotoShareContext>
    {
        public PhotoShareContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<PhotoShareContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);

            return new PhotoShareContext(builder.Options);
        }
    }
}
