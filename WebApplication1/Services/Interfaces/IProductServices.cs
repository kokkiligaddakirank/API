 
using API.ViewModels;

namespace API.Services.Interfaces
{
    public interface IProductServices
    {
        Task<List<ProductModel>> GetProducts();
        Task AddProduct(ProductModel products);
        Task UpdateProduct(int id, ProductModel products);
        Task DeleteProduct(int id);
    }
}
