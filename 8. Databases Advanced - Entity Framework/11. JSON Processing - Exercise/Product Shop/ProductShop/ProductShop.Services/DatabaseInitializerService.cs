using Microsoft.EntityFrameworkCore;
using ProductShop.Data;
using ProductShop.Services.Contracts;

namespace ProductShop.Services
{
    public class DatabaseInitializerService : IDatabaseInitializerService
    {
        private readonly ProductShopContext context;

        public DatabaseInitializerService(ProductShopContext context)
        {
            this.context = context;
        }

        public void InitializeDatabase()
        {
            this.context.Database.Migrate();
        }
    }
}
