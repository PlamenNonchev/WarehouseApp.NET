using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseApp.Data.Models;

namespace WarehouseApp.Data.Seeding
{
    public class RoomsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Rooms.Any())
            {
                return;
            }

            await dbContext.Rooms.AddAsync(new Room { Name = "Room" });

            await dbContext.SaveChangesAsync();
        }
    }
}
