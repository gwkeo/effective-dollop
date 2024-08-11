using Api.Core.Entities.DTOModels;

namespace Api.Core.Interfaces.IServices;
public interface IOrderService
{
    Task<Guid> Create(UserDTO user);
    Task<List<OrderDTO>> Read();
    Task<OrderDTO> ReadById(Guid id);
    Task Update(Guid id, OrderDTO orderDTO);
    Task Delete(Guid id);
}
