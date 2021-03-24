using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WarehouseApp.Data.Models;
using WarehouseApp.Web.ViewModels.Product;

namespace WarehouseApp.Services.Data
{
    public interface IProductsService
    {
        IList<RestockProductViewModel> GetAllProducts();

        Task RestockAsync(RestockProductInputModel input);

        Product1 GetProductById(int id);

        Task CreateAsync(CreateProductInputModel input);

        IEnumerable<ProductInListViewModel> GetCupboardProducts(int cupboardId);

       
    }
}
