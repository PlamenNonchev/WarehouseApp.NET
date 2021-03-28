using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseApp.Data.Common.Repositories;
using WarehouseApp.Data.Models;
using WarehouseApp.Services.Mapping;
using WarehouseApp.Web.ViewModels.Product;

namespace WarehouseApp.Services.Data
{
    public class ProductsService : IProductsService
    {
        private readonly IDeletableEntityRepository<Product1> productsRepository;
        private readonly IRepository<CupboardProduct> cupboardProductsRepository;
        private readonly IDeletableEntityRepository<Cupboard> cupboardsRepository;

        public ProductsService(IDeletableEntityRepository<Product1> productsRepository, IRepository<CupboardProduct> cupboardProductsRepository,IDeletableEntityRepository<Cupboard> cupboardsRepository)
        {
            this.productsRepository = productsRepository;
            this.cupboardProductsRepository = cupboardProductsRepository;
            this.cupboardsRepository = cupboardsRepository;
        }
        public IList<RestockProductViewModel> GetAllProducts()
        {
            List<RestockProductViewModel> productsList = productsRepository.AllAsNoTracking().Select(x => new RestockProductViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
            }).ToList();

            return productsList;
        }

        public Product1 GetProductById(int id)
        {
            Product1 product = productsRepository.AllAsNoTracking().Include(x => x.ProductCupboards).FirstOrDefault(p => p.Id == id);
            return product;
        }

        public async Task CreateAsync(CreateProductInputModel input)
        {
            
            var cupboards = this.cupboardsRepository.AllAsNoTracking().Include(x => x.CupboardProducts);
            var cupboard = cupboards.FirstOrDefault(c => c.Id == input.CupboardId);
            var allowedQuantity = cupboard.Capacity;
            if (input.Quantity + cupboard.CurrentLoad > allowedQuantity)
            {
                throw new Exception("Total quantity must not exceed the maximum capacity of the Cupboard!");
            }
            var product = new Product1
            {
                Name = input.Name,
                Description = input.Description,
                ImageUrl = input.ImageUrl,
                Price = input.Price,
            };

            await this.productsRepository.AddAsync(product);
            await this.productsRepository.SaveChangesAsync();

            var cupboardProduct = new CupboardProduct
            {
                CupboardId = input.CupboardId,
                Quantity = input.Quantity,
                ProductId = product.Id,
            };

            await this.cupboardProductsRepository.AddAsync(cupboardProduct);
            await this.cupboardProductsRepository.SaveChangesAsync();
        }

       

        public async Task RestockAsync(RestockProductInputModel input)
        {
            var cupboard = this.cupboardsRepository.AllAsNoTracking().Include(x => x.CupboardProducts).FirstOrDefault(c => c.Id == input.CupboardId);
            var cupboardProductIds = this.cupboardProductsRepository.AllAsNoTracking().Where(c => c.CupboardId == cupboard.Id).Select(p => p.ProductId).ToList();

            var allowedQuantity = cupboard.Capacity;
            if(input.Quantity + cupboard.CurrentLoad > allowedQuantity)
            {
                throw new Exception("Total quantity must not exceed the maximum capacity of the Cupboard!");
            }
            if (cupboardProductIds.Contains(input.ProductId))
            {
                var cupboardProduct = this.cupboardProductsRepository.AllAsNoTracking().FirstOrDefault(cp => cp.CupboardId == cupboard.Id && cp.ProductId == input.ProductId);
                cupboardProduct.Quantity += input.Quantity;
                this.cupboardProductsRepository.Update(cupboardProduct);
            }
            else
            {
                var restockedProduct = new CupboardProduct
                {
                    CupboardId = input.CupboardId,
                    Quantity = input.Quantity,
                    ProductId = input.ProductId,
                };
                await this.cupboardProductsRepository.AddAsync(restockedProduct);
            }

            await this.cupboardProductsRepository.SaveChangesAsync();
        }

        public IEnumerable<ProductInListViewModel> GetCupboardProducts(int cupboardId)
        {
            var cupboardProducts = this.cupboardProductsRepository.AllAsNoTracking().Where(x => x.CupboardId == cupboardId);
            var productsInCupboard = new List<ProductInListViewModel>();
            foreach (var cupboardProduct in cupboardProducts)
            {
                var productId = cupboardProduct.ProductId;
                var quantity = cupboardProduct.Quantity;
                var product = this.productsRepository.AllAsNoTracking().FirstOrDefault(x => x.Id == productId);
                productsInCupboard.Add(new ProductInListViewModel
                {
                    Id = product.Id,
                    ImageUrl = product.ImageUrl,
                    Name = product.Name,
                    Quantity = quantity,
                });
            }

            return productsInCupboard;
        }
    }
}
