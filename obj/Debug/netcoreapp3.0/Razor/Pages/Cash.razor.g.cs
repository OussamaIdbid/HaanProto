#pragma checksum "/Users/kerolos/Documents/GitHub/HaanProto/Pages/Cash.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b217d006be805da21b47a0e2f77eed4c89ec16dd"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/cash")]
    public class Cash : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "main-container");
            __builder.AddAttribute(2, "class", "container d-inline-flex flex-row shadow-lg");
            __builder.AddMarkupContent(3, "\n\n\t\t");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "id", "left");
            __builder.AddAttribute(6, "class", "container col-8 justify-content-start");
            __builder.AddMarkupContent(7, "\n\t\t\t");
            __builder.AddMarkupContent(8, "<div id=\"top-bar\" class=\"d-flex flex-row shadow-lg \">\n\n\t\t        <i class=\"material-icons\" id=\"menu-icon\">menu</i>\n            </div>\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "id", "product-container");
            __builder.AddAttribute(11, "class", true);
            __builder.AddMarkupContent(12, "\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "id", "items-container");
            __builder.AddAttribute(15, "class", "d-inline-flex flex-row p-2");
            __builder.AddMarkupContent(16, "\n                    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "product shadow-sm p-2 m-1");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/Cash.razor"
                                                                     RenderComponent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(20, "\n                        ");
            __builder.AddMarkupContent(21, "<p class=\"product-name\">Test Product</p>\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "product shadow-sm p-2 m-1");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/Cash.razor"
                                                                     RenderComponent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(26, "\n                        ");
            __builder.AddMarkupContent(27, "<p class=\"product-name\">Test Product</p>\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n                    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "product shadow-sm p-2 m-1");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/Cash.razor"
                                                                    RenderComponent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "\n                        ");
            __builder.AddMarkupContent(33, "<p class=\"product-name\">Test Product</p>\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n                    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "product shadow-sm p-2 m-1");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/Cash.razor"
                                                                     RenderComponent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(38, "\n                        ");
            __builder.AddMarkupContent(39, "<p class=\"product-name\">Test Product</p>\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n                    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "product shadow-sm p-2 m-1");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/Cash.razor"
                                                                     RenderComponent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(44, "\n                        ");
            __builder.AddMarkupContent(45, "<p class=\"product-name\">Test Product</p>\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n                    ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "product shadow-sm p-2 m-1");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/Cash.razor"
                                                                     RenderComponent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(50, "\n                        ");
            __builder.AddMarkupContent(51, "<p class=\"product-name\">Test Product</p>\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n                    ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "product shadow-sm p-2 m-1");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/Cash.razor"
                                                                     RenderComponent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(56, "\n                        ");
            __builder.AddMarkupContent(57, "<p class=\"product-name\">Test Product</p>\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n                    ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "product shadow-sm p-2 m-1");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/Cash.razor"
                                                                     RenderComponent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(62, "\n                        ");
            __builder.AddMarkupContent(63, "<p class=\"product-name\">Test Product</p>\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\n                    ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "product shadow-sm p-2 m-1");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/Cash.razor"
                                                                     RenderComponent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(68, "\n                        ");
            __builder.AddMarkupContent(69, "<p class=\"product-name\">Test Product</p>\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\n                    ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "product shadow-sm p-2 m-1");
            __builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/Cash.razor"
                                                                     RenderComponent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(74, "\n                        ");
            __builder.AddMarkupContent(75, "<p class=\"product-name\">Test Product</p>\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\n                    ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "product shadow-sm p-2 m-1");
            __builder.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/Cash.razor"
                                                                     RenderComponent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(80, "\n                        ");
            __builder.AddMarkupContent(81, "<p class=\"product-name\">Test Product</p>\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\n                    ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "product shadow-sm p-2 m-1");
            __builder.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/Cash.razor"
                                                                     RenderComponent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(86, "\n                        ");
            __builder.AddMarkupContent(87, "<p class=\"product-name\">Test Product</p>\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\n                    ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "product shadow-sm p-2 m-1");
            __builder.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/Cash.razor"
                                                                     RenderComponent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(92, "\n                        ");
            __builder.AddMarkupContent(93, "<p class=\"product-name\">Test Product</p>\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\n\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\n\n                ");
            __builder.AddMarkupContent(96, @"<div id=""product-category-container"" class=""d-flex flex-row p-2"">
                    <div class=""product-category shadow-sm p-2 m-1"">
                        <p class=""product-name"">Test Categorie</p>
                    </div>
                    <div class=""product-category shadow-sm p-2 m-1"">
                        <p class=""product-name"">Test Categorie</p>
                    </div>
                    <div class=""product-category shadow-sm p-2 m-1"">
                        <p class=""product-name"">Test Categorie</p>
                    </div>
                    <div class=""product-category shadow-sm p-2 m-1"">
                        <p class=""product-name"">Test Categorie</p>
                    </div>
                    <div class=""product-category shadow-sm p-2 m-1"">
                        <p class=""product-name"">Test Categorie</p>
                    </div>
                </div>

          
            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\n\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\n    \n\n\n\n        ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "id", "right");
            __builder.AddAttribute(101, "class", "container col-4 bg-white");
            __builder.AddMarkupContent(102, "\n            ");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "id", "order-container");
            __builder.AddContent(105, 
#nullable restore
#line 81 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/Cash.razor"
                                       CustomRender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\n                ");
            __builder.AddMarkupContent(107, @"<div id=""checkout-container"">
                    <div id=""price-container"" class=""text-muted"">
                        <p id=""discount"">Discount</p>
                        <p id=""subtotal"">Subtotal</p>
                        <p id=""total"">Total</p>
                    </div>
                    <div id=""checkout-buttons-container"">
                        <button type=""button"" id=""cancel-button"" class=""btn btn-lg  btn-primary shadow-sm checkout-button m-1"">Cancel</button>
                        <button type=""button"" id=""pin-button"" class=""btn btn-lg  btn-primary shadow-sm checkout-button m-1"">Pin</button>
                        <button type=""button"" id=""contant-button"" class=""btn btn-lg btn-primary shadow-sm checkout-button m-1"">Contant</button>
                    </div>
            </div>
        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/Cash.razor"
       

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
