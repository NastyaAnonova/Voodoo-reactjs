using Microsoft.AspNetCore.Mvc;
using Shop.Models.Database.Models;
using Shop.Models.Repositories.Abstract;
using Shop.Models.ViewModels.Response;
using Shop.RouteConstraints;

namespace Shop.Controllers
{
    [Route("products")]
    public class ProductsController(IProductRepository productRepository) : Controller
    {
        private readonly IProductRepository _productRepository = productRepository;

        public async Task<IActionResult> Index()
        {
            return View(await _productRepository.GetWithLimit(0, 6));
        }

        [Route("get/{type:sortingType}/{start:int}")]
        public async Task<IActionResult> Get(SortingType? type, int start)
        {
            List<ProductModel> products;

            switch (type)
            {
                case SortingType.AscendingPrice:
                    {
                        products = await _productRepository.GetWithLimitOrderByPrice(start, 6, true);
                        break;
                    }
                case SortingType.DescendingPrice:
                    {
                        products = await _productRepository.GetWithLimitOrderByPrice(start, 6);
                        break;
                    }
                case SortingType.DescendingDiscount:
                    {
                        products = await _productRepository.GetWithLimitOrderByDiscount(start, 6);
                        break;
                    }
                default:
                    {
                        products = await _productRepository.GetWithLimit(start, 6);
                        break;
                    }
            }

            List<ProductResponse> response = [.. products.Select(model => new ProductResponse
            {
                Id = model.Id,
                Name = model.Name,
                Price = model.Price,
                CategoryName = model.Category.Name,
                ImagePath = model.ImagePath,
                Percent = model.Discount?.Percent
            })];
            return Json(response);
        }
    }
}
