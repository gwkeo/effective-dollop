using Api.Core.Entities.DTOModels;

namespace Api.Core.Interfaces.IServices;

internal interface ICategoryService
{
    Task<Guid> Create(CategoryDTO category);
    Task<List<CategoryDTO>> Read();
    Task<CategoryDTO> ReadById(Guid id);
    Task Update(Guid id, CategoryDTO category);
    Task Delete(Guid id);
}
