using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association_Composition
{
    internal class Order
    {
        public int Id { get; set; }
        public string BuyerEmail { get; set; }
        public OrderItem[] orderItem { get; set; }
        public Order(OrderItem[] orderitem)
        {
            this.orderItem = orderitem;
        }
    }
}
