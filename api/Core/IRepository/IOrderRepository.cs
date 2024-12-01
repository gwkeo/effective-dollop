using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseModels;

namespace Core.IRepository
{
    public interface IOrderRepository
    {
        List<Order>? GetAsync();

        Order GetAsync(int id);

        void CreateAsync(Order order);

        void UpdateAsync(int id, Order order);

        void DeleteAsync(int id);
    }
}
