﻿using MvcWebApp.Models;

namespace MvcWebApp.Services
{
    public interface IBasketHttpService
    {
        Task<Basket> GetBasket(string userId);
        Task AddItemToBasket(string userId, BasketItem product);
        Task<Basket> UpdateBasket(Basket basket);
        Task ClearBasket(string userId);

    }
}
