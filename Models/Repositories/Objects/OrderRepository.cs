using Microsoft.EntityFrameworkCore;
using Shop.Models.Database;
using Shop.Models.Database.Models;
using Shop.Models.Repositories.Abstract;

namespace Shop.Models.Repositories.Objects
{
    public class OrderRepository(ApplicationContext context) : IOrderRepository
    {
        private readonly ApplicationContext _context = context;

        public async Task<OrderModel> Create(int accountId, List<PurchasedProductModel> purchasedProducts)
        {
            int amount = 0;

            foreach (PurchasedProductModel product in purchasedProducts)
            {
                amount += product.Cost * product.Quantity;
            }

            OrderModel orderModel = new()
            {
                Amount = amount,
                Date = DateTime.UtcNow,
                Status = OrderStatus.InProcessing,
                PurchasedProducts = purchasedProducts,
                AccountId = accountId
            };
            await _context.AddAsync(orderModel);
            await _context.SaveChangesAsync();
            return orderModel;
        }

        public async Task<bool> ChangeStatus(int orderId, OrderStatus status)
        {
            OrderModel? orderModel = await _context.Orders.FindAsync(orderId);

            if (orderModel == null) return false;

            orderModel.Status = status;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<OrderModel>> GetLastOrders(int start, int count)
        {
            return await _context.Orders
                .AsNoTracking()
                .Skip(start)
                .Take(count)
                .Include(model => model.Account)
                .OrderByDescending(model => model.Date)
                .ToListAsync();
        }

        public async Task<List<OrderModel>> GetAll()
        {
            return await _context.Orders
                .AsNoTracking()
                .Include(model => model.PurchasedProducts)
                .Include(model => model.Account)
                .ToListAsync();
        }

        public async Task<int> GetIncome()
        {
            int income = 0;
            List<PurchasedProductModel> products = await _context.PurchasedProducts
                .AsNoTracking()
                .ToListAsync();

            foreach (PurchasedProductModel product in products)
            {
                income += product.Cost * product.Quantity;
            }

            return income;
        }
    }
}
