#pragma checksum "C:\Users\Trial\Documents\GitHub\HaanProto\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35e75e74f14b423fe45095fb2e58294b811cacc0"
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
#line 1 "C:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Trial\Documents\GitHub\HaanProto\Pages\Counter.razor"
using WebApplication1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 7 "C:\Users\Trial\Documents\GitHub\HaanProto\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, 
#nullable restore
#line 8 "C:\Users\Trial\Documents\GitHub\HaanProto\Pages\Counter.razor"
    product

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenComponent<MatBlazor.MatButton>(8);
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Trial\Documents\GitHub\HaanProto\Pages\Counter.razor"
                     test

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(11, "test");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn btn-primary");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Trial\Documents\GitHub\HaanProto\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\Trial\Documents\GitHub\HaanProto\Pages\Counter.razor"
       
    int currentCount = 0;


    void IncrementCount()
    {
        currentCount++;

    }

    Product p = new Product();  
    string product;
    void test()
    {
    
    p.Name = "test";
    p.Price = 3.50;

    product = p.Name + "" + p.Price;
    }

    


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
