using System;
using System.Collections.Generic;

namespace Marketplace.Domains.Order
{
    class Order
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public OrderStatus Status { get; set; }
        public Customer.Customer Customer { get; set; }
        public List<OrderItem> Items { get; set; }

        public void addItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double total()
        {
            double total = 0.00;
            foreach (OrderItem item in Items)
            {
                total += item.subTotal();
            }

            return total;
        }
    }
}
