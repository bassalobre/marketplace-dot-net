using System;
using System.Collections.Generic;
using System.Text;

namespace Marketplace.Domains.Order
{
    class Order
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public OrderStatus Status { get; set; }

    }
}
