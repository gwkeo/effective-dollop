using Api.Core.Entities.DTOModels;
using Api.Core.Entities.Models;

namespace Api.Core.Interfaces.IRepositories
{
    public interface IOrderRepository
    {
        Task<List<Order>?> GetAsync();

        Task<Order?> GetAsync(Guid id);

        Task<Guid> CreateAsync(Order order);

        Task UpdateAsync(Order updatedOrder);

        Task DeleteAsync(Order order);
    }
}
