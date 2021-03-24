using System;
using System.Collections.Generic;
using System.Text;
using WarehouseApp.Services.Data.Models;

namespace WarehouseApp.Services.Data
{
    public interface IGetCountsService
    {
        CountsDto GetCounts();
    }
}
