using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Models.Database.Models;
using Shop.Models.Repositories.Abstract;
using Shop.Models.ViewModels.Views;

namespace Shop.Controllers
{
    public class HomeController(
        IAccountRepository accountRepository,
        IProductRepository productRepository
    ) : Controller
    {
        private readonly IAccountRepository _accountRepository = accountRepository;
        private readonly IProductRepository _productRepository = productRepository;


        [Route("/")]
        public async Task<IActionResult> Index()
        {
            MainView mainView = new()
            {
                Categories = await _productRepository.GetAllCategories(),
                NewProducts = await _productRepository.GetWithLimitOrderByCreated(0, 8),
                PopularProducts = await _productRepository.GetWithLimitOrderByCreated(0, 4)
            };
            return View(mainView);
        }

        [Route("/about")]
        public IActionResult About()
        {
            return View();
        }

        [Route("/cart")]
        public IActionResult Cart()
        {
            return View();
        }

        [Route("/contacts")]
        public IActionResult Contacts()
        {
            return View();
        }

        [Authorize]
        [Route("/profile")]
        public async Task<ActionResult> Profile()
        {
            int id = int.Parse(User.Claims.Single().Value);
            AccountModel? accountModel = await _accountRepository.GetAsync(id);

            if (accountModel == null)
            {
                return new UnauthorizedResult();
            }

            return View(accountModel);
        }
    }
}
