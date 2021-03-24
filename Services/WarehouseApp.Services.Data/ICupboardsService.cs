using System;
using System.Collections.Generic;
using System.Text;
using WarehouseApp.Web.ViewModels.Product;

namespace WarehouseApp.Services.Data
{
    public interface ICupboardsService
    {
        IList<RestockCupboardViewModel> GetAllCupboards();

        IEnumerable<T> GetCatalogCupboards<T>(int page, int itemsPerPage);

        int GetCount();
    }
}
