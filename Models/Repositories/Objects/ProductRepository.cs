using Microsoft.EntityFrameworkCore;
using Shop.Models.Database;
using Shop.Models.Database.Models;
using Shop.Models.Repositories.Abstract;

namespace Shop.Models.Repositories.Objects
{
    public class ProductRepository(ApplicationContext context) : IProductRepository
    {
        private readonly ApplicationContext _context = context;

        public async Task<List<ProductModel>> GetWithLimit(int start, int limit)
        {
            return await _context.Products
                .AsNoTracking()
                .Skip(start)
                .Take(limit)
                .Include(model => model.Discount)
                .Include(model => model.Category)
                .ToListAsync();
        }

        public async Task<List<ProductModel>> GetWithLimitOrderByPrice(int start, int limit, bool increasing = false)
        {
            if (increasing)
            {
                return await _context.Products
                    .AsNoTracking()
                    .Skip(start)
                    .Take(limit)
                    .Include(model => model.Discount)
                    .Include(model => model.Category)
                    .OrderBy(model => model.Price)
                    .ToListAsync();
            }
            else
            {
                return await _context.Products
                    .AsNoTracking()
                    .Skip(start)
                    .Take(limit)
                    .Include(model => model.Discount)
                    .Include(model => model.Category)
                    .OrderByDescending(model => model.Price)
                    .ToListAsync();
            }
        }

        public async Task<List<ProductModel>> GetWithLimitOrderByDiscount(int start, int limit)
        {
            return await _context.Products
                .AsNoTracking()
                .Skip(start)
                .Take(limit)
                .Where(model => model.Discount != null)
                .Include(model => model.Discount)
                .Include(model => model.Category)
                .OrderByDescending(model => model.Discount!.Percent)
                .ToListAsync();
        }

        public async Task<List<ProductModel>> GetWithLimitOrderByPurchases(int start, int limit)
        {
            return await _context.Products
                .AsNoTracking()
                .Skip(start)
                .Take(limit)
                .Include(model => model.Discount)
                .Include(model => model.Category)
                .OrderByDescending(model => model.PurchasedQuantity)
                .ToListAsync();
        }

        public async Task<List<ProductModel>> GetWithLimitOrderByCreated(int start, int limit)
        {
            return await _context.Products
                .AsNoTracking()
                .Skip(start)
                .Take(limit)
                .Include(model => model.Discount)
                .Include(model => model.Category)
                .OrderByDescending(model => model.CreatedAt)
                .ToListAsync();
        }

        public async Task<List<CategoryModel>> GetAllCategories()
        {
            return await _context.Categories
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<DiscountModel>> GetAllDiscounts()
        {
            return await _context.Discounts
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<ProductModel>> GetAllProducts()
        {
            return await _context.Products
                .AsNoTracking()
                .Include(model => model.Category)
                .Include(model => model.Discount)
                .ToListAsync();
        }

        public async Task<List<ProductModel>> GetPopularProducts(int start, int limit)
        {
            return await _context.Products
                .AsNoTracking()
                .Skip(start)
                .Take(limit)
                .Include(model => model.Discount)
                .Include(model => model.Category)
                .OrderByDescending(model => model.PurchasedQuantity)
                .ToListAsync();
        }

        public async Task<ProductModel?> GetById(int id)
        {
            return await _context.Products.FindAsync(id);
        }
    }
}
