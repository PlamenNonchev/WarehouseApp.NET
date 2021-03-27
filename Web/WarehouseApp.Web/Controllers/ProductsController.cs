
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WarehouseApp.Services.Data;
using WarehouseApp.Web.ViewModels.Product;

namespace WarehouseApp.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsService productsService;
        private readonly ICupboardsService cupboardsService;

        public ProductsController(IProductsService productsService, ICupboardsService cupboardsService)
        {
            this.productsService = productsService;
            this.cupboardsService = cupboardsService;
        }

        [Authorize]
        public IActionResult Create()
        {
            ViewData["CupboardsList"] = cupboardsService.GetAllCupboards().Select(x => new SelectListItem
            {
                Text = "Cupboard No." + x.Id + " : " + x.CurrentLoad.ToString() + "/" + x.Capacity.ToString(),
                Value = x.Id.ToString(),
            }).ToList();
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateProductInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                ViewData["CupboardsList"] = cupboardsService.GetAllCupboards().Select(x => new SelectListItem
                {
                    Text = "Cupboard No." + x.Id + " : " + x.CurrentLoad.ToString() + "/" + x.Capacity.ToString(),
                    Value = x.Id.ToString(),
                }).ToList();

                return this.View();
            }

            try
            {
                await this.productsService.CreateAsync(input);
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError(string.Empty, ex.Message);
                
                ViewData["CupboardsList"] = cupboardsService.GetAllCupboards().Select(x => new SelectListItem
                {
                    Text = "Cupboard No." + x.Id + " : " + x.CurrentLoad.ToString() + "/" + x.Capacity.ToString(),
                    Value = x.Id.ToString(),
                }).ToList();
                return this.View();
            }

            return this.Redirect("/");
        }

        [Authorize]
        public IActionResult Restock()
        {
            ViewData["ProductList"] = productsService.GetAllProducts().Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString(),
            }).ToList();
            ViewData["CupboardsList"] = cupboardsService.GetAllCupboards().Select(x => new SelectListItem
            {
                Text = "Cupboard No." + x.Id + " : " + x.CurrentLoad.ToString() + "/" + x.Capacity.ToString(),
                Value = x.Id.ToString(),
            }).ToList();
            return this.View();
        }


        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Restock(RestockProductInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                ViewData["ProductList"] = productsService.GetAllProducts().Select(x => new SelectListItem
                {
                    Text = x.Name ,
                    Value = x.Id.ToString(),
                }).ToList();
                ViewData["CupboardsList"] = cupboardsService.GetAllCupboards().Select(x => new SelectListItem
                {
                    Text = "Cupboard No." + x.Id + " : " + x.CurrentLoad.ToString() + "/" + x.Capacity.ToString(),
                    Value = x.Id.ToString(),
                }).ToList();
                return this.View();
            }

            try
            {
                await this.productsService.RestockAsync(input);
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError(string.Empty, ex.Message);
                ViewData["ProductList"] = productsService.GetAllProducts().Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString(),
                }).ToList();
                ViewData["CupboardsList"] = cupboardsService.GetAllCupboards().Select(x => new SelectListItem
                {
                    Text = "Cupboard No." + x.Id + " : " + x.CurrentLoad.ToString() + "/" + x.Capacity.ToString(),
                    Value = x.Id.ToString(),
                }).ToList();
                return this.View();
            }

            Random random = new Random();
            int rand = random.Next(10000, 99998);
            var product = this.productsService.GetProductById(input.ProductId);
            string total = (input.Quantity * product.Price).ToString();
            FileStream fileStream = new FileStream(@"C:\Users\plame\Desktop\Test\Test.docx", FileMode.Open, FileAccess.ReadWrite);
            WordDocument document = new WordDocument(fileStream, FormatType.Automatic);
            string[] fieldNames = new string[] {"RandNumber","ProductId", "ProductName","ProductDescription", "Price","Quantity", "Total"};
            string[] fieldValues = new string[] { rand.ToString(),product.Id.ToString(),product.Name,product.Description, product.Price.ToString(),input.Quantity.ToString(),total};
            document.MailMerge.Execute(fieldNames, fieldValues);
            MemoryStream stream = new MemoryStream();
            
            document.Save(stream, FormatType.Docx);
            stream.Position = 0;
            document.Close();
            
            return File(stream, "application/msword", "Restock_request.docx");




            return this.Redirect("/");
        }

        public IActionResult Catalog(int id = 1)
        {
            if(id <= 0)
            {
                return this.NotFound();
            }
            const int itemsPerPage = 12;
            var viewModel = new CupboardsListViewModel
            {
                ItemsPerPage = itemsPerPage,
                PageNumber = id,
                CupboardsCount = this.cupboardsService.GetCount(),
                Cupboards = this.cupboardsService.GetCatalogCupboards<CupboardInListViewModel>(id, itemsPerPage),
            };

            return this.View(viewModel);
        }

        public IActionResult Cupboard(int id)
        {

            var viewModel = new ProductsInCupboardViewModel
            {
                CupboardId = id,
                Products = this.productsService.GetCupboardProducts(id),
            };
            return this.View(viewModel);
        }

        public IActionResult Product(int id)
        {
            var product = this.productsService.GetProductById(id);

            var viewModel = new ProductDetailsViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                ImageUrl = product.ImageUrl,
                Price = product.Price,
                Quantity = product.Quantity,
                ProductCupboards = product.ProductCupboards,
                CreatedOn = product.CreatedOn,
            };
            return this.View(viewModel);
        }
    }
}
