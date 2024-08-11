using Api.Infrastructure.Data;
using Api.Core.Interfaces.IRepositories;
using Api.Core.Entities.DTOModels;
using Api.Core.Converters;
using Microsoft.EntityFrameworkCore;

namespace Api.Infrastructure.Repositories;
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationContext _context = new ApplicationContext();

        public async Task<Guid> CreateAsync(OrderDTO order)
        {
            var newOrder = OrderConverter.Convert(order);
            await _context.AddAsync(newOrder);
            await _context.SaveChangesAsync();
            return newOrder.Id;
        }

        public async void DeleteAsync(Guid id)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(x => x.Id == id) ?? throw new ArgumentException("Заказ не найден");

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
        }

        public async Task<List<OrderDTO>?> GetAsync()
        {
            var orders = await _context.Orders.ToListAsync();
            var result = OrderConverter.ConvertList(orders);
            return result;
        }

        public async Task<OrderDTO> GetAsync(Guid id)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(x =>x.Id == id) ?? throw new ArgumentException("Заказ не найден");

            var result = OrderConverter.Convert(order);
            return result;
        }

        public async void UpdateAsync(Guid id, OrderDTO updatedOrder)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(x => x.Id == id) ?? throw new ArgumentException("Заказ не найден");

            await _context.Orders
                .Where(x => x.Id == id)
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
}
