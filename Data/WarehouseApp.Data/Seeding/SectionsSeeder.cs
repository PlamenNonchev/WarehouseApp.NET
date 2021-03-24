using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseApp.Data.Models;

namespace WarehouseApp.Data.Seeding
{
    public class SectionsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Sections.Any())
            {
                return;
            }

            await dbContext.Sections.AddAsync(new Section { Name = "Section", RoomId = 1, Type = Common.SectionType.Food });

            await dbContext.SaveChangesAsync();
        }
    }
}

