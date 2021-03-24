using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarehouseApp.Data.Common.Repositories;
using WarehouseApp.Data.Models;
using WarehouseApp.Services.Mapping;
using WarehouseApp.Web.ViewModels.Product;

namespace WarehouseApp.Services.Data
{
    public class CupboardsService : ICupboardsService
    {
        private readonly IDeletableEntityRepository<Cupboard> cupboardRepository;

        public CupboardsService(IDeletableEntityRepository<Cupboard> cupboardRepository)
        {
            this.cupboardRepository = cupboardRepository;
        }

        public IList<RestockCupboardViewModel> GetAllCupboards()
        {
            var cupboards = cupboardRepository.AllAsNoTracking().Include(x => x.CupboardProducts).Select(x => new RestockCupboardViewModel
            {
                Id = x.Id,
                CurrentLoad = x.CurrentLoad,
                Capacity = x.Capacity,
            }).ToList();

            return cupboards;
        }

        public IEnumerable<T> GetCatalogCupboards<T>(int page, int itemsPerPage = 12)
        {
            var cupboards = this.cupboardRepository.AllAsNoTracking().Include(x => x.CupboardProducts)
                .OrderBy(x => x.Id)
                .Skip((page - 1) * itemsPerPage).Take(itemsPerPage)
                .To<T>()
                .ToList();

            return cupboards;
        }

        public int GetCount()
        {
            return this.cupboardRepository.All().Count();
        }
    }
}
