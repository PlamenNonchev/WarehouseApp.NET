using System;
using System.Collections.Generic;
using System.Text;
using WarehouseApp.Data.Models;
using WarehouseApp.Services.Mapping;

namespace WarehouseApp.Web.ViewModels.Product
{
    public class CupboardInListViewModel : IMapFrom<Cupboard>
    {
        public int Id { get; set; }

        public int CurrentLoad { get; set; }

        public int Capacity { get; set; }
    }
}
