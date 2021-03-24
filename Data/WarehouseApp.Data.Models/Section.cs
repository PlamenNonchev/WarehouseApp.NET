using System;
using System.Collections.Generic;
using System.Text;
using WarehouseApp.Data.Common;
using WarehouseApp.Data.Common.Models;

namespace WarehouseApp.Data.Models
{
    public class Section : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public SectionType Type { get; set; }

        public int RoomId { get; set; }

        public virtual Room Room { get; set; }
    }
}
