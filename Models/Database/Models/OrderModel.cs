namespace Shop.Models.Database.Models
{
    public enum OrderStatus
    {
        Delivered,
        InProcessing,
        AwaitingPayment,
        Sent,
        Cancelled
    }

    public class OrderModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public OrderStatus Status { get; set; }
        public int AccountId { get; set; }
        public AccountModel Account { get; set; } = new();
        public List<PurchasedProductModel> PurchasedProducts { get; set; } = [];
    }
}
