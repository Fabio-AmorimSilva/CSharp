#pragma checksum "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindMvc/Views/Home/ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0480f97610aa907aef26ac26e74bf7fde19a3bfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductDetail), @"mvc.1.0.view", @"/Views/Home/ProductDetail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindMvc/Views/_ViewImports.cshtml"
using NorthwindMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindMvc/Views/_ViewImports.cshtml"
using NorthwindMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0480f97610aa907aef26ac26e74bf7fde19a3bfe", @"/Views/Home/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c10324db967624bce2cebb2dbfaf1321bdbfb158", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Packt.CS7.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindMvc/Views/Home/ProductDetail.cshtml"
  
    ViewData["Title"] = "Product Detail - " + Model.ProductName;


#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Product Detail</h2>\n<hr />\n<div>\n    <dl class=\"dl-horizontal\">\n        <dt>Product ID</dt>\n        <dd>");
#nullable restore
#line 13 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindMvc/Views/Home/ProductDetail.cshtml"
       Write(Model.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n        <dt>Product Name</dt>\n        <dd>");
#nullable restore
#line 15 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindMvc/Views/Home/ProductDetail.cshtml"
       Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n        <dt>Category ID</dt>\n        <dd>");
#nullable restore
#line 17 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindMvc/Views/Home/ProductDetail.cshtml"
       Write(Model.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n        <dt>Unit Price</dt>\n        <dd>");
#nullable restore
#line 19 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindMvc/Views/Home/ProductDetail.cshtml"
       Write(Model.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n        <dt>Units In Stock</dt>\n        <dd>");
#nullable restore
#line 21 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindMvc/Views/Home/ProductDetail.cshtml"
       Write(Model.UnitsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n    </dl>\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Packt.CS7.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591