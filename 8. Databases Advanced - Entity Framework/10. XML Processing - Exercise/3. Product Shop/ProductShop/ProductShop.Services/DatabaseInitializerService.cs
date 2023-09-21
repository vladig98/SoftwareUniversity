using Microsoft.EntityFrameworkCore;
using ProductShop.Data;
using ProductShop.Services.Contracts;

namespace ProductShop.Services
{
    public class DatabaseInitializerService : IDatabaseInitializerService
    {
        private readonly ProductShopDbContext context;

        public DatabaseInitializerService(ProductShopDbContext context)
        {
            this.context = context;
        }

        public void InitializeDatabase()
        {
            this.context.Database.Migrate();
        }
    }
}
