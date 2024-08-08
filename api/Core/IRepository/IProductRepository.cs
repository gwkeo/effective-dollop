using DatabaseModels.DTOModels;
namespace Core.IRepository
{
    public interface IProductRepository
    {
        Task<List<ProductDTO>?> GetAsync();

        Task<ProductDTO?> GetAsync(Guid id); 
        
        Task<Guid> CreateAsync(ProductDTO product);
        
        Task UpdateAsync(Guid id, ProductDTO product);
        
        Task DeleteAsync(Guid id);
    }
}
