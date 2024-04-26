using API.Entites;
using API.Repos.Interfaces;
using API.Services.Interfaces;
using API.ViewModels;

namespace API.Services.Implementations
{
    public class ProductServices : IProductServices
    {
        private readonly IProductRepo _repo;
        public ProductServices(IProductRepo repo)
        {
            _repo = repo;
        }

        public async Task AddProduct(ProductModel products)
        {
            var obj = new Products()
            {
                Name = products.Name,
                Price = products.Price,
            };
            await _repo.Add(obj);
        }

        public async Task DeleteProduct(int id)
        {
            await _repo.Delete(id);
        }

        public async Task<List<ProductModel>> GetProducts()
        {
            var result = new List<ProductModel>();
            var products = await _repo.Get();
            foreach (var item in products)
            {
                var obj = new ProductModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Price = item.Price,
                };
                result.Add(obj);
            }
            return result;
        }

        public async Task UpdateProduct(int id, ProductModel products)
        {
            var obj = new Products()
            {
                Id = id,
                Name = products.Name,
                Price = products.Price,
            };
            await _repo.Update(id, obj);
        }
    }
}
