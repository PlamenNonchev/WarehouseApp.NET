using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseApp.Web.ViewModels.Product
{
    public class RestockCupboardViewModel
    {
        public int Id { get; set; }

        public int CurrentLoad { get; set; }

        public int Capacity { get; set; }
    }
}
