using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseApp.Web.ViewModels.Product
{
    public class CupboardsListViewModel : PagingViewModel
    {
        public IEnumerable<CupboardInListViewModel> Cupboards { get; set; }

        
    }
}
