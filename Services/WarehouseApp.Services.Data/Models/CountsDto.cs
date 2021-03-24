using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseApp.Services.Data.Models
{
    public class CountsDto
    {
        public int ProductsCount { get; set; }

        public int CupboardsCount { get; set; }

        public int SectionsCount { get; set; }

        public int RoomsCount { get; set; }
    }
}
