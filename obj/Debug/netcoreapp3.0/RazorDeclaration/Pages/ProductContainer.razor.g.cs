<<<<<<< HEAD
#pragma checksum "/Users/kerolos/Documents/GitHub/HaanProto/Pages/ProductContainer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "708c9e27f7ebf75fcc1d32aea52506ed2efcc3c6"
=======
#pragma checksum "c:\Users\Trial\Documents\GitHub\HaanProto\Pages\ProductContainer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f30db84e0eae280b0775ada554209d3ea2dcb508"
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
#nullable restore
<<<<<<< HEAD
#line 2 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/ProductContainer.razor"
=======
#line 2 "c:\Users\Trial\Documents\GitHub\HaanProto\Pages\ProductContainer.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
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
<<<<<<< HEAD
#line 25 "/Users/kerolos/Documents/GitHub/HaanProto/Pages/ProductContainer.razor"
=======
#line 28 "c:\Users\Trial\Documents\GitHub\HaanProto\Pages\ProductContainer.razor"
>>>>>>> bbeee46549fc2ced1e1eac3abfd270a5ee0104bd
      
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
