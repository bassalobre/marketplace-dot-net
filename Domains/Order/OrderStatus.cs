namespace Marketplace.Domains.Order
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Devivered = 3
    }
}
