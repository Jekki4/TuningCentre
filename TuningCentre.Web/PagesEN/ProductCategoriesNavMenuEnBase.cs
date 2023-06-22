using Microsoft.AspNetCore.Components;
using TuningCentre.Models.Dtos;
using TuningCentre.Web.Services.Contracts;

namespace TuningCentre.Web.PagesEn
{
    public class ProductCategoriesNavMenuEnBase:ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }

        public IEnumerable<ProductCategoryDto> ProductCategoryDtos { get; set; }

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                ProductCategoryDtos = await ProductService.GetProductCategories();
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}
