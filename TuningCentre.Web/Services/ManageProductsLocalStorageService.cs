using Blazored.LocalStorage;
using TuningCentre.Models.Dtos;
using TuningCentre.Web.Services.Contracts;

namespace TuningCentre.Web.Services
{
    public class ManageProductsLocalStorageService : IManageProductsLocalStorageService
    {
        private readonly Blazored.LocalStorage.ILocalStorageService localStorageService;
        private readonly IProductService productService;

        private const string key = "ProductCollection";

        public ManageProductsLocalStorageService(Blazored.LocalStorage.ILocalStorageService localStorageService,
                                                 IProductService productService)
        {
            this.localStorageService = localStorageService;
            this.productService = productService;
        }

        public async Task<IEnumerable<ProductDto>> GetCollection()
        {
            return await localStorageService.GetItemAsync<IEnumerable<ProductDto>>(key)
                    ?? await AddCollection();
        }

        public async Task RemoveCollection()
        {
            await localStorageService.RemoveItemAsync(key);
        }

        private async Task<IEnumerable<ProductDto>> AddCollection()
        {
            var productCollection = await productService.GetItems();

            if (productCollection != null)
            {
                await localStorageService.SetItemAsync(key, productCollection);
            }

            return productCollection;

        }

    }
}
