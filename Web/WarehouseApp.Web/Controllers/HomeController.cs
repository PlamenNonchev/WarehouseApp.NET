namespace WarehouseApp.Web.Controllers
{
    using System.Diagnostics;

    using WarehouseApp.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;
    using WarehouseApp.Services.Data;
    using WarehouseApp.Web.ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly IGetCountsService getCountsService;

        public HomeController(IGetCountsService getCountsService)
        {
            this.getCountsService = getCountsService;
        }
        public IActionResult Index()
        {
            var countsDto = this.getCountsService.GetCounts();
            var viewModel = new IndexViewModel()
            {
                ProductsCount = countsDto.ProductsCount,
                CupboardsCount = countsDto.CupboardsCount,
                SectionsCount = countsDto.SectionsCount,
                RoomsCount = countsDto.RoomsCount,
            };

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
