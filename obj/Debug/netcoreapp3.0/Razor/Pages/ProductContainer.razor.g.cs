#pragma checksum "c:\Users\Trial\Documents\GitHub\HaanProto\Pages\ProductContainer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3d6205643536834b7ff07271b09fcb3e77adef9"
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
#line 2 "c:\Users\Trial\Documents\GitHub\HaanProto\Pages\ProductContainer.razor"
using WebApplication1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/productcontainer")]
    public class ProductContainer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "mat-layout-grid");
            __builder.AddMarkupContent(2, "\r\n            ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "mat-layout-grid-inner");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 9 "c:\Users\Trial\Documents\GitHub\HaanProto\Pages\ProductContainer.razor"
              if (products == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "                ");
            __builder.AddMarkupContent(7, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 12 "c:\Users\Trial\Documents\GitHub\HaanProto\Pages\ProductContainer.razor"
            }
            else
            {   
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "c:\Users\Trial\Documents\GitHub\HaanProto\Pages\ProductContainer.razor"
             foreach (var product in products)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "                ");
            __builder.OpenComponent<MatBlazor.MatButton>(9);
            __builder.AddAttribute(10, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "c:\Users\Trial\Documents\GitHub\HaanProto\Pages\ProductContainer.razor"
                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "class", "product-test mat-layout-grid-cell mat-layout-grid-cell-span-2");
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n                    ");
                __builder2.AddContent(14, 
#nullable restore
#line 18 "c:\Users\Trial\Documents\GitHub\HaanProto\Pages\ProductContainer.razor"
                     product.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(15, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 20 "c:\Users\Trial\Documents\GitHub\HaanProto\Pages\ProductContainer.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "c:\Users\Trial\Documents\GitHub\HaanProto\Pages\ProductContainer.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "                \r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "c:\Users\Trial\Documents\GitHub\HaanProto\Pages\ProductContainer.razor"
      
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
