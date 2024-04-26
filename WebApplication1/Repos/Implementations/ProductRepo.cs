using API.Entites;
using API.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Repos.Implementations
{
    public class ProductRepo : IProductRepo
    {
        private readonly ProductDbContext _dbContext;
        public ProductRepo(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Products products)
        {
            if (products == null) throw new ArgumentNullException(nameof(products));
            else
            {
                await _dbContext.Products.AddAsync(products);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            var prodcut = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (prodcut != null)
            {
                _dbContext.Products.Remove(prodcut);
                _dbContext.SaveChanges();
            }
        }

        public async Task<List<Products>> Get()
        {
            var products = await _dbContext.Products.ToListAsync();
            return products;
        }

        public async Task Update(int id, Products products)
        {
            var prodcut = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (prodcut != null)
            {
                prodcut.Price = products.Price;
                prodcut.Name = products.Name;
                _dbContext.SaveChanges();
            }
        }
    }
}
