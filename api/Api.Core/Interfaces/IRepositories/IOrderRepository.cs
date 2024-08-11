using Api.Core.Entities.DTOModels;

namespace Api.Core.Interfaces.IRepositories
{
    public interface IOrderRepository
    {
        Task<List<OrderDTO>?> GetAsync();

        Task<OrderDTO> GetAsync(Guid id);

        Task<Guid> CreateAsync(OrderDTO order);

        void UpdateAsync(Guid id, OrderDTO updatedOrder);

        void DeleteAsync(Guid id);
    }
}
