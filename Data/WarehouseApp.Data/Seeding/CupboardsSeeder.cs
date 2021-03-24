using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseApp.Data.Models;

namespace WarehouseApp.Data.Seeding
{
    public class CupboardsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Cupboards.Any())
            {
                return;
            }

            await dbContext.Cupboards.AddAsync(new Cupboard { SectionId = 1, Capacity = 100, IsFull = false });
            await dbContext.Cupboards.AddAsync(new Cupboard { SectionId = 1, Capacity = 200, IsFull = false });

            await dbContext.SaveChangesAsync();
        }
    }
}
