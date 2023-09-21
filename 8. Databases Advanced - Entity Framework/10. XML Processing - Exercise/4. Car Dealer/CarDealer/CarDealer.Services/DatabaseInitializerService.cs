using CarDealer.Data;
using CarDealer.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace CarDealer.Services
{
    public class DatabaseInitializerService : IDatabaseInitializerService
    {
        private readonly CarDealerDbContext context;

        public DatabaseInitializerService(CarDealerDbContext context)
        {
            this.context = context;
        }

        public void InitializeDatabase()
        {
            this.context.Database.Migrate();
        }
    }
}
