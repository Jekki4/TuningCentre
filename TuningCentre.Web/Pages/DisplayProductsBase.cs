﻿using Microsoft.AspNetCore.Components;
using TuningCentre.Models.Dtos;

namespace TuningCentre.Web.Pages
{
    public class DisplayProductsEnBase:ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
