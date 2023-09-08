using Microsoft.EntityFrameworkCore;
using Pizzeria.Data;
using Pizzeria.Services.Contracts;

namespace Pizzeria.Services
{
    public class DbInitializerService : IDbInitializerService
    {
        private readonly PizzeriaContext context;

        public DbInitializerService(PizzeriaContext context)
        {
            this.context = context;
        }

        public void InitializeDatabase()
        {
            context.Database.Migrate();
        }
    }
}
