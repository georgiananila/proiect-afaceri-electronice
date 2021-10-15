using FurnitureWebStore.Models.DTOs;
using FurnitureWebStore.Models.DTOs.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureWebStore.Models.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductVM> GetAllProducts();
        ProductVM GetProduct(int id);
        void AddProduct(ProductVM dto);
        void UpdateProduct(int id, ProductVM dto);
        void DeleteProduct(int id);

        List<IdNameDto> GetProductTypes();

    }
}
