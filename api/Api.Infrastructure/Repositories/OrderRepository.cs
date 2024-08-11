using Api.Infrastructure.Data;
using Api.Core.Interfaces.IRepositories;
using Api.Core.Entities.Models;
using Api.Core.Converters;
using Microsoft.EntityFrameworkCore;

namespace Api.Infrastructure.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly ApplicationContext _context = new ApplicationContext();

    public async Task<Guid> CreateAsync(Order order)
    {
        await _context.Orders.AddAsync(order);
        await _context.SaveChangesAsync();
        return order.Id;
    }

    public async Task DeleteAsync(Order order)
    {
        _context.Orders.Remove(order);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Order>?> GetAsync()
    {
        return await _context.Orders.ToListAsync();
    }

    public async Task<Order?> GetAsync(Guid id)
    {
        return await _context.Orders.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task UpdateAsync(Order updatedOrder)
    {
        await _context.Orders
            .Where(x => x.Id == updatedOrder.Id)
                .ExecuteUpdateAsync(x => x
                .SetProperty(y => y.Id, updatedOrder.Id)
                .SetProperty(y => y.UserId, updatedOrder.UserId)
                .SetProperty(y => y.ProductsIds, updatedOrder.ProductsIds)
                .SetProperty(y => y.AddressFrom, updatedOrder.AddressFrom)
                .SetProperty(y => y.AddressTo, updatedOrder.AddressTo)
                .SetProperty(y => y.DateTimeDelivered, updatedOrder.DateTimeDelivered)
                .SetProperty(y => y.DateTimeOrdered, updatedOrder.DateTimeOrdered));

        await _context.SaveChangesAsync();
    }
}
