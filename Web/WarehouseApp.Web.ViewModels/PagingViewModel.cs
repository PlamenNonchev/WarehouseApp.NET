using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseApp.Web.ViewModels
{
    public class PagingViewModel
    {
        public int PageNumber { get; set; }

        public bool HasPreviousPage => this.PageNumber > 1;

        public int PreviousPageNumber => this.PageNumber - 1;

        public bool HasNextPage => this.PageNumber < this.PagesCount;

        public int NextPageNumber => this.PageNumber + 1;

        public int CupboardsCount { get; set; }

        public int PagesCount => (int)Math.Ceiling((double)this.CupboardsCount / this.ItemsPerPage);

        public int ItemsPerPage { get; set; }
    }
}
