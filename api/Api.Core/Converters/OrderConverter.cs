using Api.Core.Entities.Models;
using Api.Core.Entities.DTOModels;

namespace Api.Core.Converters;

public static class OrderConverter
{
    public static Order Convert(OrderDTO _)
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

    public static OrderDTO Convert(Order _)
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

    public static List<Order> ConvertList(List<OrderDTO> _)
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

    public static List<OrderDTO> ConvertList(List<Order> _)
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