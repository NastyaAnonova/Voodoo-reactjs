using Shop.Models.Database.Models;

namespace Shop.Models.ViewModels.Views
{
    public class AdminView
    {
        public int OrdersCount { get; set; }
        public int ProductsCount { get; set; }
        public int DiscountCount { get; set; }
        public int Income { get; set; }
        public AccountModel Account { get; set; } = new();
        public List<OrderModel> Orders { get; set; } = [];
        public List<OrderModel> LastOrders { get; set; } = [];
        public List<ProductModel> Products { get; set; } = [];
        public List<ProductModel> PopularProducts { get; set; } = [];
        public List<DiscountModel> Discounts { get; set; } = [];
    }
}
