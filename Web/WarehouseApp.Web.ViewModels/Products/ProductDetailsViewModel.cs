using System;
using System.Collections.Generic;
using System.Text;
using WarehouseApp.Data.Models;
using WarehouseApp.Services.Mapping;

namespace WarehouseApp.Web.ViewModels.Product
{
    public class ProductDetailsViewModel : IMapFrom<Product1>
    {
        public ProductDetailsViewModel()
        {
            this.ProductCupboards = new HashSet<CupboardProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public DateTime CreatedOn { get; set; }

        public virtual ICollection<CupboardProduct> ProductCupboards { get; set; }
    }
}
