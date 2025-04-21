using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Models.Database.Models;
using Shop.Models.Repositories.Abstract;
using Shop.Models.ViewModels.Views;

namespace Shop.Controllers
{
    [Route("admin")]
    public class AdminController
    (
        IProductRepository productRepository,
        IOrderRepository orderRepository,
        IAccountRepository accountRepository
    ) : Controller
    {
        private readonly IProductRepository _productRepository = productRepository;
        private readonly IOrderRepository _orderRepository = orderRepository;
        private readonly IAccountRepository _accountRepository = accountRepository;

        [Authorize]
        public async Task<IActionResult> Index()
        {
            int id = int.Parse(User.Claims.Single().Value);
            AccountModel? accountModel = await _accountRepository.GetAsync(id);

            if (accountModel == null)
            {
                return new UnauthorizedResult();
            }

            List<DiscountModel> discounts = await _productRepository.GetAllDiscounts();
            List<OrderModel> orders = await _orderRepository.GetAll();
            List<ProductModel> products = await _productRepository.GetAllProducts();
            AdminView adminView = new()
            {
                Discounts = discounts,
                DiscountCount = discounts.Count,
                PopularProducts = await _productRepository.GetPopularProducts(0, 3),
                Products = products,
                Account = accountModel,
                Orders = orders,
                OrdersCount = orders.Count,
                ProductsCount = products.Count,
                LastOrders = await _orderRepository.GetLastOrders(0, 4),
                Income = await _orderRepository.GetIncome()
            };
            return View(adminView);
        }
    }
}
