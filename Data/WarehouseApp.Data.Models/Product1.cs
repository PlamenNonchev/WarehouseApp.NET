using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarehouseApp.Data.Common.Models;

namespace WarehouseApp.Data.Models
{
    public class Product1 : BaseDeletableModel<int>
    {
        public Product1()
        {
            this.ProductCupboards = new HashSet<CupboardProduct>();
        }
        public string   Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int Quantity => this.ProductCupboards.Sum(pc => pc.Quantity);

        public decimal Price { get; set; }

        public virtual ICollection<CupboardProduct> ProductCupboards { get; set; }
    }
}
