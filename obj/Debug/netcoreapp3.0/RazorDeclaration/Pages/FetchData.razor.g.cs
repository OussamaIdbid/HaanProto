<<<<<<< HEAD
#pragma checksum "c:\Users\Trial\Documents\GitHub\HaanProto\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a92265c9d60db69888275c17ac4b951518c9d16"
=======
#pragma checksum "/Users/kerolos/Documents/GitHub/HaanProto/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6990ca97a7a4444422e1335e97149a3482686d2"
>>>>>>> c4fc8864c15fe058bcaf5c6f101f265e661ff94e
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
=======
#line 1 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
>>>>>>> c4fc8864c15fe058bcaf5c6f101f265e661ff94e
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
=======
#line 2 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
>>>>>>> c4fc8864c15fe058bcaf5c6f101f265e661ff94e
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 3 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
=======
#line 3 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
>>>>>>> c4fc8864c15fe058bcaf5c6f101f265e661ff94e
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 4 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
=======
#line 4 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
>>>>>>> c4fc8864c15fe058bcaf5c6f101f265e661ff94e
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 5 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
=======
#line 5 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
>>>>>>> c4fc8864c15fe058bcaf5c6f101f265e661ff94e
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 6 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
=======
#line 6 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
>>>>>>> c4fc8864c15fe058bcaf5c6f101f265e661ff94e
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 7 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
=======
#line 7 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
>>>>>>> c4fc8864c15fe058bcaf5c6f101f265e661ff94e
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 8 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
=======
#line 8 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
>>>>>>> c4fc8864c15fe058bcaf5c6f101f265e661ff94e
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 9 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
=======
#line 9 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
>>>>>>> c4fc8864c15fe058bcaf5c6f101f265e661ff94e
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 3 "c:\Users\Trial\Documents\GitHub\HaanProto\Pages\FetchData.razor"
=======
#line 3 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/FetchData.razor"
>>>>>>> c4fc8864c15fe058bcaf5c6f101f265e661ff94e
using WebApplication1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
<<<<<<< HEAD
#line 39 "c:\Users\Trial\Documents\GitHub\HaanProto\Pages\FetchData.razor"
=======
#line 39 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/FetchData.razor"
>>>>>>> c4fc8864c15fe058bcaf5c6f101f265e661ff94e
       
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
