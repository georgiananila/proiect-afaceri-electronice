using AutoMapper;
using FurnitureWebStore.Models.DTOs.VM;
using FurnitureWebStore.Models.Entities;

namespace FurnitureWebStore.Models
{
    public static class MapperConfig
    {
        public static IMapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
              {
                  cfg.CreateMap<ProductType, ProductTypeVM>();
                  cfg.CreateMap<ProductTypeVM, ProductType>();


                  cfg.CreateMap<Product, ProductVM>();
                  cfg.CreateMap<ProductVM, Product>();
              });
            return config.CreateMapper();
        }
    }
}
