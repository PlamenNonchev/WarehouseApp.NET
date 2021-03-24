using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarehouseApp.Services.Data;
using WarehouseApp.Web.ViewModels.Product;

namespace WarehouseApp.Web.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PriceController : BaseController
    {
        private readonly IProductsService productsService;

        public PriceController(IProductsService productsService)
        {
            this.productsService = productsService;
        }
       
        public async Task<ActionResult<ProductPriceViewModel>> Price(int productId)
        {
            var productPrice = this.productsService.GetAllProducts().FirstOrDefault(p => p.Id == productId).Price;
            var product = new ProductPriceViewModel
            {
                Price = productPrice
            };

            return product;

                
        }
    }
}
