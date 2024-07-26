using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModels
{
    public class Order
    {
        public int Id { get; set; } 

        public int UserId { get; set; }

        public string AddressFrom { get; set; } = string.Empty;

        public string AddressTo { get; set; } = string.Empty;

        public List<int> ProductsIds { get; set; } = [];

        public DateTime DateTimeOrdered { get; set; }

        public DateTime DateTimeDelivered { get; set; }

        public List<Order> Orders { get; set; } = [];
    }
}
