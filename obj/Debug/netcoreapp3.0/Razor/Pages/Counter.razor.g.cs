<<<<<<< HEAD
#pragma checksum "/Users/kerolos/Documents/GitHub/HaanProto/Pages/Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49d1370be4dbc4c019116e61d6d56e041fc9c38b"
=======
#pragma checksum "/Users/Nadir/Documents/GitHub/HaanProto/Pages/Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49d1370be4dbc4c019116e61d6d56e041fc9c38b"
>>>>>>> 6d4c43ebc322114e47fa5c98d5484285fffaf261
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
#line 1 "/Users/Nadir/Documents/GitHub/HaanProto/_Imports.razor"
>>>>>>> 6d4c43ebc322114e47fa5c98d5484285fffaf261
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 2 "/Users/Nadir/Documents/GitHub/HaanProto/_Imports.razor"
>>>>>>> 6d4c43ebc322114e47fa5c98d5484285fffaf261
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 3 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 3 "/Users/Nadir/Documents/GitHub/HaanProto/_Imports.razor"
>>>>>>> 6d4c43ebc322114e47fa5c98d5484285fffaf261
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 4 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 4 "/Users/Nadir/Documents/GitHub/HaanProto/_Imports.razor"
>>>>>>> 6d4c43ebc322114e47fa5c98d5484285fffaf261
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 5 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 5 "/Users/Nadir/Documents/GitHub/HaanProto/_Imports.razor"
>>>>>>> 6d4c43ebc322114e47fa5c98d5484285fffaf261
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 6 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 6 "/Users/Nadir/Documents/GitHub/HaanProto/_Imports.razor"
>>>>>>> 6d4c43ebc322114e47fa5c98d5484285fffaf261
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 7 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 7 "/Users/Nadir/Documents/GitHub/HaanProto/_Imports.razor"
>>>>>>> 6d4c43ebc322114e47fa5c98d5484285fffaf261
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 8 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 8 "/Users/Nadir/Documents/GitHub/HaanProto/_Imports.razor"
>>>>>>> 6d4c43ebc322114e47fa5c98d5484285fffaf261
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 9 "/Users/kerolos/Documents/GitHub/HaanProto/_Imports.razor"
=======
#line 9 "/Users/Nadir/Documents/GitHub/HaanProto/_Imports.razor"
>>>>>>> 6d4c43ebc322114e47fa5c98d5484285fffaf261
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\n\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
<<<<<<< HEAD
#line 5 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/Counter.razor"
=======
#line 5 "/Users/Nadir/Documents/GitHub/HaanProto/Pages/Counter.razor"
>>>>>>> 6d4c43ebc322114e47fa5c98d5484285fffaf261
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
<<<<<<< HEAD
#line 7 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/Counter.razor"
=======
#line 7 "/Users/Nadir/Documents/GitHub/HaanProto/Pages/Counter.razor"
>>>>>>> 6d4c43ebc322114e47fa5c98d5484285fffaf261
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
<<<<<<< HEAD
#line 9 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/Counter.razor"
=======
#line 9 "/Users/Nadir/Documents/GitHub/HaanProto/Pages/Counter.razor"
>>>>>>> 6d4c43ebc322114e47fa5c98d5484285fffaf261
       
    int currentCount = 0;

    void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
