using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseApp.Data.Models;

namespace WarehouseApp.Data.Seeding
{
    public class ProductsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Products.Any())
            {
                return;
            }

            await dbContext.Products.AddAsync(new Product1 { Name = "Orange", Description = "sweet and sour", Price = 10.99M, ImageUrl = "https://brkelgmbh.com/wp-content/uploads/2018/02/orange-web04.jpg" });

            await dbContext.Products.AddAsync(new Product1 { Name = "Apple", Description = "sweet", Price = 9.99M, ImageUrl = "https://i2.wp.com/ceklog.kindel.com/wp-content/uploads/2013/02/firefox_2018-07-10_07-50-11.png?fit=641%2C618&ssl=1" });

            await dbContext.Products.AddAsync(new Product1 { Name = "Banana", Description = "sweet", Price = 8.99M, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/8/8a/Banana-Single.jpg" });

            await dbContext.Products.AddAsync(new Product1 { Name = "Strawberry", Description = "sweet and sour", Price = 7.99M, ImageUrl = "https://befreshcorp.net/wp-content/uploads/2017/07/product-packshot-strawberrie-558x600.jpg" });

            await dbContext.Products.AddAsync(new Product1 { Name = "Grape", Description = "sweet and sour", Price = 6.99M, ImageUrl = "https://www.aicr.org/wp-content/uploads/2020/01/shutterstock_533487490-640x462.jpg" });

            await dbContext.Products.AddAsync(new Product1 { Name = "Carrot", Description = "sweet", Price = 5.99M, ImageUrl = "https://cdn.shopify.com/s/files/1/1380/2059/products/Carrot-Orange_grande.jpg?v=1598079671" });

            await dbContext.Products.AddAsync(new Product1 { Name = "Potato", Description = "neutral", Price = 4.99M, ImageUrl = "https://happilyf.com/wp-content/uploads/2020/08/potato.jpg" });
            await dbContext.Products.AddAsync(new Product1 { Name = "Tomato", Description = "sour", Price = 3.99M, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/88/Bright_red_tomato_and_cross_section02.jpg/800px-Bright_red_tomato_and_cross_section02.jpg" });

            await dbContext.Products.AddAsync(new Product1 { Name = "Onion", Description = "spicy", Price = 2.99M, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSvvJaZ-4aSXQoZcMNs6yKq648k4S0CxrsCmCesLbzLZkUneNna_dVUEyUzprQdxliDk_E&usqp=CAU" });

            await dbContext.Products.AddAsync(new Product1 { Name = "Broccoli", Description = "neutral", Price = 1.99M, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTdrBfzqgouIqj43w49fQuylMBUDyGlToztumov-NRBRfOl6i5BZbV4OiBaqgFFzBkHOnc&usqp=CAU" });







            await dbContext.SaveChangesAsync();
        }
    }
}
