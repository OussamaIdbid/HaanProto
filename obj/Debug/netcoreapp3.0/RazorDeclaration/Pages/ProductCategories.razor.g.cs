#pragma checksum "c:\Users\Trial\Documents\GitHub\HaanProto\Pages\ProductCategories.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6544f9cf40ae99d693f17a529af02fe979313158"
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
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Trial\Documents\GitHub\HaanProto\Pages\ProductCategories.razor"
using WebApplication1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Trial\Documents\GitHub\HaanProto\Pages\ProductCategories.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/productcategories")]
    public class ProductCategories : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "c:\Users\Trial\Documents\GitHub\HaanProto\Pages\ProductCategories.razor"
      
    [parameter]
    
    IEnumerable<Category> categories;
    IEnumerable<Product> products; 
     
  
    protected override async Task OnInitializedAsync()  
    {  
        categories = await CategoryService.GetCategories();
        

    }






#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService CategoryService { get; set; }
    }
}
#pragma warning restore 1591
