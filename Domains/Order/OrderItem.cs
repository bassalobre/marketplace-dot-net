namespace Marketplace.Domains.Order
{
    class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product.Product Product { get; set; }

        public double subTotal()
        {
            return Quantity * Price;
        }
    }
}
