using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseApp.Data.Models
{
    public class CupboardProduct
    {
        public int Id { get; set; }
        public int CupboardId { get; set; }

        public virtual Cupboard Cupboard { get; set; }

        public int ProductId { get; set; }

        public virtual Product1 Product { get; set; }

        public int Quantity { get; set; }
    }
}
