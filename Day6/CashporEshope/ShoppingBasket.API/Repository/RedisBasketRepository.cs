using Newtonsoft.Json;
using ShoppingBasket.API.Domain;
using StackExchange.Redis;

namespace ShoppingBasket.API.Repository
{
    public class RedisBasketRepository : IBasketRepository
    {
        private readonly ConnectionMultiplexer _conRedis;
        private readonly IDatabase _database;
        public RedisBasketRepository(ConnectionMultiplexer con)
        {
            _conRedis = con;
            _database = con.GetDatabase();

        }
        public async Task<bool> DeleteBasketAsync(string buyerId)
        {
          return  await _database.KeyDeleteAsync(buyerId);
        }

        public async Task<Basket> GetBasket(string buyerId)
        {
           
           var data = await _database.StringGetAsync(buyerId);
            if (data.IsNullOrEmpty)
            {
                return null;
            }
            return JsonConvert.DeserializeObject<Basket>(data);
        }

        public IEnumerable<string> GetBuyers()
        {
            return null;
        }

        public async Task<Basket> UpdateBasketAsync(Basket basket)
        {
            var created = await _database.StringSetAsync(basket.BuyerId, JsonConvert.SerializeObject(basket));
            if (!created)
            {
                throw new ApplicationException("Basket cannot be saved");
            }

            return await GetBasket(basket.BuyerId);
        }
    }
}
