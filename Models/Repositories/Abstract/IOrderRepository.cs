using Shop.Models.Database.Models;

namespace Shop.Models.Repositories.Abstract
{
    public interface IOrderRepository
    {
        public Task<OrderModel> Create(int accountId, List<PurchasedProductModel> purchasedProducts);

        public Task<bool> ChangeStatus(int orderId, OrderStatus status);

        public Task<List<OrderModel>> GetLastOrders(int start, int count);

        public Task<List<OrderModel>> GetAll();

        public Task<int> GetIncome();
    }
}
