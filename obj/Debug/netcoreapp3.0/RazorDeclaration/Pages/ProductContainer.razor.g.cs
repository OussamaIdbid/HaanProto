#pragma checksum "/Users/kerolos/Documents/GitHub/HaanProto/Pages/ProductContainer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc6d9e79571dfb2117d3159da04807a74bbd64d6"
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
#line 1 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/ProductContainer.razor"
using WebApplication1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/productcontainer")]
    public partial class ProductContainer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/ProductContainer.razor"
      
    IEnumerable<Product> products;  
  
    protected override async Task OnInitializedAsync()  
    {  
        products = await ProductService.GetProducts();  
    }  

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
