using Api.Core.Entities.Models;

namespace Api.Core.Interfaces.IRepositories
{
    public interface IProductRepository
    {
        Task<List<Product>?> GetAsync();

        Task<Product?> GetAsync(Guid id); 
        
        Task<Guid> CreateAsync(Product product);
        
        Task UpdateAsync(Product newProduct);
        
        Task DeleteAsync(Product product);
    }
}
