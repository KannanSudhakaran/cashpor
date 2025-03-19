using Microsoft.AspNetCore.Mvc;
using MvcWebApp.Models;
using MvcWebApp.Services;
using System.Threading.Tasks;

namespace MvcWebApp.Controllers
{
    public class BasketController : Controller
    {
        private string _buyerId = "userPradip";
        private readonly ICatalogHttpServcie _catalogServcie;
        private readonly IBasketHttpService _basketHttpService;

        public BasketController(ICatalogHttpServcie catalogServcie, IBasketHttpService basketHttpService)
        {

            _catalogServcie = catalogServcie;
            _basketHttpService = basketHttpService;

        }
        public async Task<IActionResult> Index()
        {
          var basket= await  _basketHttpService.GetBasket(_buyerId);


           return View(basket);
        }

        public async Task<IActionResult> AddToBasket(int id)
        {
            //basket --> BuyId,catlogItem
         var catalogItem=   await _catalogServcie.GetCatalogItemDetails(id);

            if(catalogItem == null)
            {
                return NotFound();
            }
            var basket = new Basket();
            basket.BuyerId = _buyerId;
            basket.Items = new List<BasketItem>()
            {
                new BasketItem()
                {
                   Id = Guid.NewGuid().ToString(),
                  ProductId = catalogItem.Id,
                  ProductName = catalogItem.Name,
                   Quantity = 1,
                  UnitPrice = catalogItem.Price,
                }
            };
            //call baskethttp service
           await _basketHttpService.AddItemToBasket(_buyerId, basket.Items[0]);

            return RedirectToAction("Index","Catalog");
        }
    }
}
