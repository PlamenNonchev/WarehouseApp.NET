using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WarehouseApp.Web.ViewModels.Product
{
    public class RestockProductInputModel
    {
        public int ProductId { get; set; }

     

        [Range(0,1000)]
        public int Quantity { get; set; }

        public int CupboardId { get; set; }
    }
}
