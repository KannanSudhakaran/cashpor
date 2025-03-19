using Microsoft.Build.Framework;
using MvcWebApp.Models;
using Newtonsoft.Json;

namespace MvcWebApp.Services
{
    public class BasketHttpService : IBasketHttpService
    {

        private readonly string _baseUrl;

        public BasketHttpService(IConfiguration config)
        {
            _baseUrl = config["ShoppingBaskeBaseUrl"];
        }
        public async Task AddItemToBasket(string userId, BasketItem product)
        {
            //how to handle mulplie click for same product
            var basket = await GetBasket(userId);
           var matchingProduct= basket.Items
                 .Where(p => p.ProductId == product.ProductId)
                 .FirstOrDefault();

            if (matchingProduct == null) {
                basket.Items.Add(product);
            }
            else
            {
                matchingProduct.Quantity += 1;
            }

            await UpdateBasket(basket);

        }

        public async Task ClearBasket(string userId)
        {
            var client = new HttpClient();
           await client.DeleteAsync(_baseUrl + "/api/v1/basket/" + userId);
        }

        public async Task<Basket> GetBasket(string userId)
        {
            var basket = new Basket()
            {
                BuyerId = userId,
                Items = new List<BasketItem>()
            };
            var client = new HttpClient();
            var dataString=  await client.GetStringAsync(_baseUrl+ "/api/v1/basket/"+userId);
            if (dataString != "")
            {
                 basket = JsonConvert.DeserializeObject<Basket>(dataString);
            }
           
           return basket;
        }

        public async Task<Basket> UpdateBasket(Basket basket)
        {
            var client = new HttpClient();
            HttpContent content = new StringContent(JsonConvert.SerializeObject(basket), System.Text.Encoding.UTF8, "application/json");

           var response= await client.PostAsync(_baseUrl + "/api/v1/basket", content);
            if (response.IsSuccessStatusCode)
            {
                return basket;
            }
            else
            {
                throw new Exception("Error in updating basket");
            }
        }
    }
}
