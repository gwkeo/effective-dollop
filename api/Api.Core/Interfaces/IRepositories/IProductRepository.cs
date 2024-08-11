using Api.Core.Entities.DTOModels;

namespace Api.Core.Interfaces.IRepositories
{
    public interface IProductRepository
    {
        Task<List<ProductDTO>?> GetAsync();

        Task<ProductDTO?> GetAsync(Guid id); 
        
        Task<Guid> CreateAsync(ProductDTO product);
        
        Task UpdateAsync(Guid id, ProductDTO newProduct);
        
        Task DeleteAsync(Guid id);
    }
}
