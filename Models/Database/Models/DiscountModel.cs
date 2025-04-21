namespace Shop.Models.Database.Models
{
    public class DiscountModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Percent { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public List<ProductModel> Products { get; set; } = [];
    }
}
