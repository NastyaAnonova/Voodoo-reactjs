using Shop.Models.Database.Models;

namespace Shop.Models.ViewModels.Views
{
    public class MainView
    {
        public List<CategoryModel> Categories { get; set; } = [];
        public List<ProductModel> NewProducts { get; set; } = [];
        public List<ProductModel> PopularProducts { get; set; } = [];
    }
}
