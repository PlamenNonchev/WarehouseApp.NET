using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseApp.Data.Models;

namespace WarehouseApp.Data.Seeding
{
    public class CupboardProductsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.CupboardProducts.Any())
            {
                return;
            }

            await dbContext.CupboardProducts.AddAsync(new CupboardProduct {CupboardId = 1, ProductId = 1, Quantity = 5 });

            await dbContext.CupboardProducts.AddAsync(new CupboardProduct { CupboardId = 1, ProductId = 2, Quantity = 10 });

            await dbContext.CupboardProducts.AddAsync(new CupboardProduct { CupboardId = 1, ProductId = 3, Quantity = 15 });

            await dbContext.CupboardProducts.AddAsync(new CupboardProduct { CupboardId = 1, ProductId = 4, Quantity = 20 });

            await dbContext.CupboardProducts.AddAsync(new CupboardProduct { CupboardId = 1, ProductId = 5, Quantity = 25 });

            await dbContext.CupboardProducts.AddAsync(new CupboardProduct { CupboardId = 2, ProductId = 6, Quantity = 30 });

            await dbContext.CupboardProducts.AddAsync(new CupboardProduct { CupboardId = 2, ProductId = 7, Quantity = 35 });

            await dbContext.CupboardProducts.AddAsync(new CupboardProduct { CupboardId = 2, ProductId = 8, Quantity = 40 });

            await dbContext.CupboardProducts.AddAsync(new CupboardProduct { CupboardId = 2, ProductId = 9, Quantity = 45 });

            await dbContext.CupboardProducts.AddAsync(new CupboardProduct { CupboardId = 2, ProductId = 10, Quantity = 50 });







            await dbContext.SaveChangesAsync();
        }
    }
}
