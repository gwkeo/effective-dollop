using Api.Core.Entities.DTOModels;

namespace Api.Core.Interfaces.IServices;

public interface IProductService
{
    Task<Guid> Create(ProductDTO productDTO);
    Task<List<ProductDTO>> Read();
    Task<ProductDTO> ReadById(Guid id);
    Task Update(Guid id, ProductDTO productDTO);
    Task Delete(Guid id);
}
