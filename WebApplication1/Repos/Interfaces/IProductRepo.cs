using API.Entites;

namespace API.Repos.Interfaces
{
    public interface IProductRepo
    {
        Task<List<Products>> Get();
        Task Add(Products products);
        Task Update(int id, Products products);
        Task Delete(int id);

    }
}
