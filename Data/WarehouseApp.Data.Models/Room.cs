using System;
using System.Collections.Generic;
using System.Text;
using WarehouseApp.Data.Common.Models;

namespace WarehouseApp.Data.Models
{
    public class Room : BaseDeletableModel<int>
    {
        public string Name { get; set; }
    }
}
