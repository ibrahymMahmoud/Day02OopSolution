using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association_Composition
{
    internal class OrderItem
    {
        public int Id { get; set; }
        public Product product { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }

        public void Order(Product product)
        {
            this.product = product;
        }
    }
}
