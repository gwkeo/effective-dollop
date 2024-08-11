using Api.Core.Entities.DTOModels;

namespace Api.Core.Interfaces.IServices;
public interface IOrderService
{
    Task<Guid> Create(OrderDTO orderDto);
    Task<List<OrderDTO>> Read();
    Task<OrderDTO> ReadById(Guid id);
    Task Update(Guid id, OrderDTO orderDto);
    Task Delete(Guid id);
}
