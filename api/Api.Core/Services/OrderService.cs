using Api.Core.Converters;
using Api.Core.Entities.DTOModels;
using Api.Core.Interfaces.IRepositories;
using Api.Core.Interfaces.IServices;

namespace Api.Core.Services;

public class OrderService(IOrderRepository repo) : IOrderService
{
    private readonly IOrderRepository _repo = repo;
    
    public async Task<Guid> Create(OrderDTO orderDto)
    {
        var order = OrderConverter.Convert(orderDto);
        return await _repo.CreateAsync(order);
    }

    public async Task<List<OrderDTO>> Read()
    {
        var orders = await _repo.GetAsync() ?? throw new Exception("Список заказов пуст");
        var result = OrderConverter.ConvertList(orders);
        return result;
    }

    public async Task<OrderDTO> ReadById(Guid id)
    {
        var order = await _repo.GetAsync(id) ?? throw new ArgumentException("Закан не найден");
        var result = OrderConverter.Convert(order);
        return result;
    }

    public async Task Update(Guid id, OrderDTO orderDto)
    {
        var order = await _repo.GetAsync(id) ?? throw new ArgumentException("Заказ не найден");
        var updatedOrder = OrderConverter.Convert(orderDto);
        updatedOrder.Id = id;
        await _repo.UpdateAsync(updatedOrder);
    }

    public async Task Delete(Guid id)
    {
        var order = await _repo.GetAsync(id) ?? throw new ArgumentException("Заказ не найден");
        await _repo.DeleteAsync(order);
    }
}