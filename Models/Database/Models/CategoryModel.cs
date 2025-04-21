namespace Shop.Models.Database.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public List<ProductModel> Products { get; set; } = [];
    }
}
