#pragma checksum "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindEmployees/Areas/PacktFeatures/Pages/employees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ed8819181ed9f436d870af36decee84339e8dd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PacktFeatures_Pages_employees), @"mvc.1.0.razor-page", @"/Areas/PacktFeatures/Pages/employees.cshtml")]
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
#line 2 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindEmployees/Areas/PacktFeatures/Pages/employees.cshtml"
using Packt.CS7;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ed8819181ed9f436d870af36decee84339e8dd5", @"/Areas/PacktFeatures/Pages/employees.cshtml")]
    public class Areas_PacktFeatures_Pages_employees : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <h1 class=\"display-2\">Employees</h1>\r\n</div>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 10 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindEmployees/Areas/PacktFeatures/Pages/employees.cshtml"
     foreach(string name in Model.name)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card border-dark mb-3\" style=\"max-width: 18rem;\">\r\n            <div class=\"card-header\">\r\n                ");
#nullable restore
#line 14 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindEmployees/Areas/PacktFeatures/Pages/employees.cshtml"
           Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 17 "/home/fabio/Documentos/Linguagens de Programação/C#.NET/ModernC#/Chapter14/NorthwindEmployees/Areas/PacktFeatures/Pages/employees.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NorthwindEmployees.PacktFeatures.Pages.EmployeesPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NorthwindEmployees.PacktFeatures.Pages.EmployeesPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NorthwindEmployees.PacktFeatures.Pages.EmployeesPageModel>)PageContext?.ViewData;
        public NorthwindEmployees.PacktFeatures.Pages.EmployeesPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
