#pragma checksum "D:\STUDIA\aspdotnet\Salary\Salary_Distribution\Views\Salary\Salaries.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1901f5783c48ca597e841c0c883f7543b54de21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Salary_Salaries), @"mvc.1.0.view", @"/Views/Salary/Salaries.cshtml")]
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
#line 1 "D:\STUDIA\aspdotnet\Salary\Salary_Distribution\Views\_ViewImports.cshtml"
using Salary_Distribution;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\STUDIA\aspdotnet\Salary\Salary_Distribution\Views\_ViewImports.cshtml"
using Salary_Distribution.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1901f5783c48ca597e841c0c883f7543b54de21", @"/Views/Salary/Salaries.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa00244784309e086ac1f21cd2b9c52f1c9f1eb4", @"/Views/_ViewImports.cshtml")]
    public class Views_Salary_Salaries : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SalariesModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1> Wypłaty</h1>\r\n\r\n");
#nullable restore
#line 4 "D:\STUDIA\aspdotnet\Salary\Salary_Distribution\Views\Salary\Salaries.cshtml"
Write(Html.DropDownListFor(m => m.WorkingTime,
    new SelectList(Enum.GetNames(typeof(Salary_Distribution.Models.SalariesModel.WorkTime))),
    "Wybierz miesiąc"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SalariesModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
