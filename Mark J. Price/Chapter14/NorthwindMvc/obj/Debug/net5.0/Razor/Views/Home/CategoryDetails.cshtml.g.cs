#pragma checksum "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindMvc/Views/Home/CategoryDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6990212c1be95541cc708e923cd89f5a98a18a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CategoryDetails), @"mvc.1.0.view", @"/Views/Home/CategoryDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6990212c1be95541cc708e923cd89f5a98a18a1", @"/Views/Home/CategoryDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c10324db967624bce2cebb2dbfaf1321bdbfb158", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CategoryDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Packt.CS7.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindMvc/Views/Home/CategoryDetails.cshtml"
  
    ViewData["Title"] = "Category Detail - " + Model.CategoryName;


#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Category Detail</h2>\n<hr/>\n<div>\n    <dl class=\"dl-horizontal\">\n        <dt>Category ID</dt>\n        <dd>");
#nullable restore
#line 13 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindMvc/Views/Home/CategoryDetails.cshtml"
       Write(Model.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n        <dt>Category Name</dt>\n        <dd>");
#nullable restore
#line 15 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindMvc/Views/Home/CategoryDetails.cshtml"
       Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n        <dt>Category Description</dt>\n        <dd>");
#nullable restore
#line 17 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindMvc/Views/Home/CategoryDetails.cshtml"
       Write(Model.Description);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Packt.CS7.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
