<<<<<<< HEAD
#pragma checksum "/Users/kerolos/Documents/GitHub/HaanProto/Pages/Cash.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eba9d9d40937f853780361a7e2af8e1832d67c68"
=======
#pragma checksum "c:\Users\Trial\Documents\GitHub\HaanProto\Pages\Cash.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4445a3511ad44beb1855d41ecaf290b560f2064a"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
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
#line 1 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 1 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 2 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 3 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 3 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 4 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 4 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 5 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 5 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 6 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 6 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 7 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 7 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 8 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 8 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 9 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 9 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 10 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 10 "c:\Users\Trial\Documents\GitHub\HaanProto\_Imports.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
using MatBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cash")]
    public partial class Cash : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
<<<<<<< HEAD
#line 41 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/Cash.razor"
=======
#line 42 "c:\Users\Trial\Documents\GitHub\HaanProto\Pages\Cash.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
       

    RenderFragment CustomRender { get; set;}
    RenderFragment CreateItem() => builder =>
    {
        builder.OpenComponent(0, typeof(OrderLine));
        builder.AddAttribute(1, "name", "TEST PRODUCT");
        builder.AddAttribute(1, "amount", "2");
        builder.AddAttribute(1, "price", "3.80");
        builder.CloseComponent();
        


    };
    void RenderComponent(){

        CustomRender = CreateItem();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
