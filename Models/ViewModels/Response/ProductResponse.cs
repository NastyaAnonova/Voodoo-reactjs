namespace Shop.Models.ViewModels.Response
{
    public class ProductResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
        public string ImagePath { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public int? Percent { get; set; }
    }
}
