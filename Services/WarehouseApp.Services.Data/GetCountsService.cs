using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarehouseApp.Data.Common.Repositories;
using WarehouseApp.Data.Models;
using WarehouseApp.Services.Data.Models;

namespace WarehouseApp.Services.Data
{
    public class GetCountsService : IGetCountsService
    {
        private readonly IDeletableEntityRepository<Cupboard> cupboardsRepository;
        private readonly IDeletableEntityRepository<Product1> productsRepository;
        private readonly IDeletableEntityRepository<Section> sectionsRepository;
        private readonly IDeletableEntityRepository<Room> roomsRepository;

        public GetCountsService(IDeletableEntityRepository<Cupboard> cupboardsRepository, IDeletableEntityRepository<Product1> productsRepository,
            IDeletableEntityRepository<Section> sectionsRepository, IDeletableEntityRepository<Room> roomsRepository)
        {
            this.cupboardsRepository = cupboardsRepository;
            this.productsRepository = productsRepository;
            this.sectionsRepository = sectionsRepository;
            this.roomsRepository = roomsRepository;
        }

        public CountsDto GetCounts()
        {
            var data = new CountsDto
            {
                ProductsCount = this.productsRepository.All().Count(),
                CupboardsCount = this.cupboardsRepository.All().Count(),
                SectionsCount = this.sectionsRepository.All().Count(),
                RoomsCount = this.roomsRepository.All().Count(),
            };

            return data;
        }
    }
}
