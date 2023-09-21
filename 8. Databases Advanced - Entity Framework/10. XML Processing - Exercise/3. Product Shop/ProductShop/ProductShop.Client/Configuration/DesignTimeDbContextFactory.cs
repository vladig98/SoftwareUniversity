using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ProductShop.Data;
using System.IO;

namespace ProductShop.Client.Configuration
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ProductShopDbContext>
    {
        public ProductShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<ProductShopDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);

            return new ProductShopDbContext(builder.Options);
        }
    }
}
