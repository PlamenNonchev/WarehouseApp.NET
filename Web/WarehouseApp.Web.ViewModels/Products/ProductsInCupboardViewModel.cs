using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseApp.Web.ViewModels.Product
{
    public class ProductsInCupboardViewModel
    {
        public IEnumerable<ProductInListViewModel> Products { get; set; }

        public int CupboardId { get; set; }

    }
}
