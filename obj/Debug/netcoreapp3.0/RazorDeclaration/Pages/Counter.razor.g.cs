#pragma checksum "c:\Users\gebruiker1\Documents\GitHub\HaanProto\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35e75e74f14b423fe45095fb2e58294b811cacc0"
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
#line 1 "c:\Users\gebruiker1\Documents\GitHub\HaanProto\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\gebruiker1\Documents\GitHub\HaanProto\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\gebruiker1\Documents\GitHub\HaanProto\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\gebruiker1\Documents\GitHub\HaanProto\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\gebruiker1\Documents\GitHub\HaanProto\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\gebruiker1\Documents\GitHub\HaanProto\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\gebruiker1\Documents\GitHub\HaanProto\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\gebruiker1\Documents\GitHub\HaanProto\_Imports.razor"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\gebruiker1\Documents\GitHub\HaanProto\_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\gebruiker1\Documents\GitHub\HaanProto\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\gebruiker1\Documents\GitHub\HaanProto\Pages\Counter.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "c:\Users\gebruiker1\Documents\GitHub\HaanProto\Pages\Counter.razor"
       
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
