using Microsoft.AspNetCore.Mvc;
using WebAplication.Dto;
using WebAplication.Models;

namespace WebAplication.Abstraction
{
    public interface IProductRepository
    {
        IEnumerable<ProductDto> GetAllProducts();
        int AddProduct(ProductDto productDto);
        void DeleteProduct(int id);
    }
}
