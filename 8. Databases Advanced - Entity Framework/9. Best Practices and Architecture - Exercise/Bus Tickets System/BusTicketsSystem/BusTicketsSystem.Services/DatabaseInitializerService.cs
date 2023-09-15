using BusTicketsSystem.Data;
using BusTicketsSystem.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BusTicketsSystem.Services
{
    public class DatabaseInitializerService : IDatabaseInitializerService
    {
        private readonly BusTicketsSystemContext context;

        public DatabaseInitializerService(BusTicketsSystemContext context)
        {
            this.context = context;
        }

        public void InitializeDatabase()
        {
            this.context.Database.Migrate();
        }
    }
}
