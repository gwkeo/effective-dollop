using Api.Core.Entities.Models;

namespace Api.Core.Interfaces.IRepositories;

public interface ICategoryRepository
{
    Task<List<Category>?> GetAsync();

    Task<Category?> GetAsync(Guid id);

    Task<Guid?> CreateAsync(Category category);

    Task UpdateAsync(Category updatedCategory);
    
    Task DeleteAsync(Category category);
}
