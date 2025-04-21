namespace Shop.Models.Database.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int PurchasedQuantity { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string ImagePath { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; } = new();
        public int? DiscountId { get; set; }
        public DiscountModel? Discount { get; set; }
    }
}
