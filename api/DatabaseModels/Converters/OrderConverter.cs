using DatabaseModels.Models;
using DatabaseModels.DTOModels;

namespace DatabaseModels.Converters;

public class OrderConverter
{
    public Order Convert(OrderDTO _)
    {
        return new Order
        (
            _.Id, 
            _.UserId, 
            _.AddressFrom, 
            _.AddressTo, 
            _.ProductsIds, 
            _.DateTimeOrdered, 
            _.DateTimeDelivered
        );
    }

    public OrderDTO Convert(Order _)
    {
        return new OrderDTO
        (
            _.Id,
            _.UserId,
            _.AddressFrom,
            _.AddressTo,
            _.ProductsIds,
            _.DateTimeOrdered,
            _.DateTimeDelivered
        );
    }

    public List<Order> ConvertListAsync(List<OrderDTO> _)
    {
        var orders = new List<Order>();
        foreach (var order in _)
        {
            orders.Add(new Order
            (
                order.Id,
                order.UserId,
                order.AddressFrom,
                order.AddressTo,
                order.ProductsIds,
                order.DateTimeOrdered,
                order.DateTimeDelivered
            ));
        }

        return orders;
    }

    public List<OrderDTO> ConvertListAsync(List<Order> _)
    {
        var newOrders = new List<OrderDTO>();
        foreach (var order in _)
        {
            newOrders.Add(new OrderDTO
            (
                order.Id,
                order.UserId,
                order.AddressFrom,
                order.AddressTo,
                order.ProductsIds,
                order.DateTimeOrdered,
                order.DateTimeDelivered
            ));
        }

        return newOrders;
    }
}