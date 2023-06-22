using Microsoft.AspNetCore.Components;
using TuningCentre.Models.Dtos;

namespace TuningCentre.Web.PagesEn
{
    public class DisplayProductsEnBase:ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
