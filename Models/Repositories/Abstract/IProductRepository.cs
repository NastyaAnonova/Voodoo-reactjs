using Shop.Models.Database.Models;

namespace Shop.Models.Repositories.Abstract
{
    public interface IProductRepository
    {
        public Task<List<ProductModel>> GetWithLimit(int start, int limit);

        public Task<List<ProductModel>> GetWithLimitOrderByPrice(int start, int limit, bool increasing = false);

        public Task<List<ProductModel>> GetWithLimitOrderByDiscount(int start, int limit);

        public Task<List<ProductModel>> GetWithLimitOrderByCreated(int start, int limit);

        public Task<List<ProductModel>> GetWithLimitOrderByPurchases(int start, int limit);

        public Task<List<CategoryModel>> GetAllCategories();

        public Task<List<DiscountModel>> GetAllDiscounts();

        public Task<List<ProductModel>> GetAllProducts();

        public Task<List<ProductModel>> GetPopularProducts(int start, int limit);

        public Task<ProductModel?> GetById(int id);
    }
}
