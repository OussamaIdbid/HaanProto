<<<<<<< HEAD
#pragma checksum "/Users/kerolos/Documents/GitHub/HaanProto/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6990ca97a7a4444422e1335e97149a3482686d2"
=======
#pragma checksum "C:\Users\Trial\Documents\GitHub\HaanProto\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a92265c9d60db69888275c17ac4b951518c9d16"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
<<<<<<< HEAD
#line 1 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 1 "C:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 2 "C:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 3 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 3 "C:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 4 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 4 "C:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 5 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 5 "C:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 6 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 6 "C:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 7 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 7 "C:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 8 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 8 "C:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 9 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 9 "C:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 10 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 10 "C:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 3 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/FetchData.razor"
=======
#line 3 "C:\Users\Trial\Documents\GitHub\HaanProto\Pages\FetchData.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
using WebApplication1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\n\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\n\n");
#nullable restore
<<<<<<< HEAD
#line 10 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/FetchData.razor"
=======
#line 10 "C:\Users\Trial\Documents\GitHub\HaanProto\Pages\FetchData.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\n");
#nullable restore
<<<<<<< HEAD
#line 13 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/FetchData.razor"
=======
#line 13 "C:\Users\Trial\Documents\GitHub\HaanProto\Pages\FetchData.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\n        ");
            __builder.AddMarkupContent(8, "<thead>\n            <tr>\n                <th>Date</th>\n                <th>Temp. (C)</th>\n                <th>Temp. (F)</th>\n                <th>Summary</th>\n            </tr>\n        </thead>\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\n");
#nullable restore
<<<<<<< HEAD
#line 26 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/FetchData.razor"
=======
#line 26 "C:\Users\Trial\Documents\GitHub\HaanProto\Pages\FetchData.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
<<<<<<< HEAD
#line 29 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/FetchData.razor"
=======
#line 29 "C:\Users\Trial\Documents\GitHub\HaanProto\Pages\FetchData.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
                         forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
<<<<<<< HEAD
#line 30 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/FetchData.razor"
=======
#line 30 "C:\Users\Trial\Documents\GitHub\HaanProto\Pages\FetchData.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
<<<<<<< HEAD
#line 31 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/FetchData.razor"
=======
#line 31 "C:\Users\Trial\Documents\GitHub\HaanProto\Pages\FetchData.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
<<<<<<< HEAD
#line 32 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/FetchData.razor"
=======
#line 32 "C:\Users\Trial\Documents\GitHub\HaanProto\Pages\FetchData.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
                         forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n");
#nullable restore
<<<<<<< HEAD
#line 34 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/FetchData.razor"
=======
#line 34 "C:\Users\Trial\Documents\GitHub\HaanProto\Pages\FetchData.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n");
#nullable restore
<<<<<<< HEAD
#line 37 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/FetchData.razor"
=======
#line 37 "C:\Users\Trial\Documents\GitHub\HaanProto\Pages\FetchData.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
<<<<<<< HEAD
#line 39 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/FetchData.razor"
=======
#line 39 "C:\Users\Trial\Documents\GitHub\HaanProto\Pages\FetchData.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
       
    WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
