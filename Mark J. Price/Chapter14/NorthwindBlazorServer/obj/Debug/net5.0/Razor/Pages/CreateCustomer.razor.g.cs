#pragma checksum "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindBlazorServer/Pages/CreateCustomer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db498f390b8ecc43c89dd5d8faa2ceced74c6d1b"
// <auto-generated/>
#pragma warning disable 1591
namespace NorthwindBlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindBlazorServer/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindBlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindBlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindBlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindBlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindBlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindBlazorServer/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindBlazorServer/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindBlazorServer/_Imports.razor"
using NorthwindBlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindBlazorServer/_Imports.razor"
using NorthwindBlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindBlazorServer/_Imports.razor"
using NorthwindBlazorServer.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindBlazorServer/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindBlazorServer/_Imports.razor"
using Packt.CS7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindBlazorServer/_Imports.razor"
using NorthwindContextLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindBlazorServer/_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/createcustomer")]
    public partial class CreateCustomer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Create Customer</h3>\n");
            __builder.OpenComponent<NorthwindBlazorServer.Pages.CustomerDetail>(1);
            __builder.AddAttribute(2, "ButtonText", "Create Customer");
            __builder.AddAttribute(3, "Customer", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Packt.CS7.Customer>(
#nullable restore
#line 7 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindBlazorServer/Pages/CreateCustomer.razor"
                           customer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 8 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindBlazorServer/Pages/CreateCustomer.razor"
                                Create

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindBlazorServer/Pages/CreateCustomer.razor"
       
    private Customer customer = new Customer();

    private async Task Create(){
        await service.CreateCustomerAsync(customer);
        navigation.NavigateTo("customer");
        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INorthwindService service { get; set; }
    }
}
#pragma warning restore 1591
