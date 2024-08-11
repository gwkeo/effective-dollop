using Api.Core.Entities.DTOModels;

namespace Api.Core.Interfaces.IRepositories;

public interface ICategoryRepository
{
    Task<List<CategoryDTO>?> GetAsync();

    Task<CategoryDTO?> GetAsync(Guid id);

    Task<Guid> CreateAsync(CategoryDTO category);

    Task UpdateAsync(Guid id, CategoryDTO updatedCategory);
    
    Task DeleteAsync(Guid id);
}
