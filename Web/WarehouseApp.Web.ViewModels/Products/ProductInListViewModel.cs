using System;
using System.Collections.Generic;
using System.Text;
using WarehouseApp.Data.Models;
using WarehouseApp.Services.Mapping;

namespace WarehouseApp.Web.ViewModels.Product
{
    public class ProductInListViewModel 
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public string ImageUrl { get; set; }
    }
}
