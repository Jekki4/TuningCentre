using TuningCentre.Models.Dtos;
using TuningCentre.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace TuningCentre.Web.PagesEn
{
    public class ProductsBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }


        [Inject]
        public IManageProductsLocalStorageService ManageProductsLocalStorageService { get; set; }

        public IEnumerable<ProductDto> Products { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                await ClearLocalStorage();

                Products = await ManageProductsLocalStorageService.GetCollection();
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;

            }

        }

        protected IOrderedEnumerable<IGrouping<int, ProductDto>> GetGroupedProductsByCategory()
        {
            return from product in Products
                   group product by product.CategoryId into prodByCatGroup
                   orderby prodByCatGroup.Key
                   select prodByCatGroup;
        }
        protected string GetCategoryName(IGrouping<int, ProductDto> groupedProductDtos)
        {
            return groupedProductDtos.FirstOrDefault(pg => pg.CategoryId == groupedProductDtos.Key).CategoryName;
        }

        private async Task ClearLocalStorage()
        {
            await ManageProductsLocalStorageService.RemoveCollection();
        }

    }
}