using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarehouseApp.Data.Common.Models;

namespace WarehouseApp.Data.Models
{
    public class Cupboard : BaseDeletableModel<int>
    {
        public Cupboard()
        {
            this.CupboardProducts = new HashSet<CupboardProduct>();
        }

        public int Capacity { get; set; }

        public int CurrentLoad => this.CupboardProducts.Sum(cp => cp.Quantity);

        public bool IsFull { get; set; }

        public int SectionId { get; set; }

        public Section Section { get; set; }

        public virtual ICollection<CupboardProduct> CupboardProducts { get; set; }

    }
}
