using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingBasket.API.Domain;
using ShoppingBasket.API.Repository;

namespace ShoppingBasket.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketRepository _repository;
        public BasketController(IBasketRepository repository) { 
        
            _repository = repository;
        }

        [HttpGet("{buyerId}")]
        public async Task<ActionResult<Basket>> GetBasket(string buyerId)
        {
            var basket = await _repository.GetBasket(buyerId);
            return Ok(basket);
        }

        [HttpPost]
        public async Task<ActionResult<Basket>> UpdateBasket(Basket basket)
        {
            var updatedBasket = await _repository.UpdateBasketAsync(basket);
            return Ok(updatedBasket);
        }

        [HttpDelete("{buyerId}")]
        public async Task DeleteBuyer(string buyerId) {

           await _repository.DeleteBasketAsync(buyerId);
        
        }



    }
}
