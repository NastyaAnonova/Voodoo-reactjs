namespace Shop.Models.Database.Models
{
    public class PurchasedProductModel
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public ProductModel Product { get; set; } = new();
        public int OrderId { get; set; }
        public OrderModel Order { get; set; } = new();
    }
}
