using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseApp.Web.ViewModels.Product
{
    public class RestockProductViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
