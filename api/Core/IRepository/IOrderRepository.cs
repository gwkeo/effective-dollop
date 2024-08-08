using DatabaseModels.DTOModels;

namespace Core.IRepository
{
    public interface IOrderRepository
    {
        Task<List<OrderDTO>?> GetAsync();

        Task<OrderDTO> GetAsync(Guid id);

        Task<Guid> CreateAsync(OrderDTO order);

        void UpdateAsync(Guid id, OrderDTO order);

        void DeleteAsync(Guid id);
    }
}
