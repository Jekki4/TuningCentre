﻿using Blazored.LocalStorage;
using TuningCentre.Models.Dtos;
using TuningCentre.Web.Services.Contracts;

namespace TuningCentre.Web.Services
{
    public class ManageCartItemsLocalStorageService : IManageCartItemsLocalStorageService
    {
        private readonly Blazored.LocalStorage.ILocalStorageService localStorageService;
        private readonly IShoppingCartService shoppingCartService;

        const string key = "CartItemCollection";

        public ManageCartItemsLocalStorageService(Blazored.LocalStorage.ILocalStorageService localStorageService,
                                                  IShoppingCartService shoppingCartService)
        {
            this.localStorageService = localStorageService;
            this.shoppingCartService = shoppingCartService;
        }

        public async Task<List<CartItemDto>> GetCollection()
        {
            return await this.localStorageService.GetItemAsync<List<CartItemDto>>(key)
                    ?? await AddCollection();
        }

        public async Task RemoveCollection()
        {
           await this.localStorageService.RemoveItemAsync(key);
        }

        public async Task SaveCollection(List<CartItemDto> cartItemDtos)
        {
            await this.localStorageService.SetItemAsync(key,cartItemDtos);
        }

        private async Task<List<CartItemDto>> AddCollection()
        {

            var shoppingCartCollection = await this.shoppingCartService.GetItems(HardCoded.UserId);
            
            if(shoppingCartCollection != null)
            {
                await this.localStorageService.SetItemAsync(key, shoppingCartCollection);
            }

            return shoppingCartCollection;

        }

    }
}
