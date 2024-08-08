using DatabaseModels.DTOModels;

namespace Core.IRepository
{
    public interface ICategoryRepository
    {
        Task<List<CategoryDTO>?> GetAsync();

        Task<CategoryDTO?> GetAsync(Guid id);

        Task<Guid> CreateAsync(CategoryDTO category);

        Task UpdateAsync(Guid id, CategoryDTO category);
        
        Task DeleteAsync(Guid id);
    }
}
