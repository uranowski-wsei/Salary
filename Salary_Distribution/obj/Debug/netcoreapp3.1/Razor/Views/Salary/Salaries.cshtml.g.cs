#pragma checksum "E:\Studia Programowanie\Salary\Salary_Distribution\Views\Salary\Salaries.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24364e7e855e84e6fcbe3a7a43eb2c4cc4b6a687"
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
#line 1 "E:\Studia Programowanie\Salary\Salary_Distribution\Views\_ViewImports.cshtml"
using Salary_Distribution;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Studia Programowanie\Salary\Salary_Distribution\Views\_ViewImports.cshtml"
using Salary_Distribution.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24364e7e855e84e6fcbe3a7a43eb2c4cc4b6a687", @"/Views/Salary/Salaries.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa00244784309e086ac1f21cd2b9c52f1c9f1eb4", @"/Views/_ViewImports.cshtml")]
    public class Views_Salary_Salaries : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SalariesModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/salariesControl.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"salaries-page\" id=\"salariesPage\">\r\n    <div class=\"head\">\r\n        <div class=\"head-left\">\r\n            <h1> Wypłaty</h1>\r\n\r\n            ");
#nullable restore
#line 8 "E:\Studia Programowanie\Salary\Salary_Distribution\Views\Salary\Salaries.cshtml"
       Write(Html.DropDownListFor(m => m.WorkingTime,
                new SelectList(Enum.GetNames(typeof(Salary_Distribution.Models.SalariesModel.WorkTime))),
                "Wybierz miesiąc"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <div class=""head-right"" id=""hoursPlace"">

        </div>
    </div>

    <input name=""inputMoney"" id=""inputMoney"" placeholder=""Podaj budżet w danym miesiącu"" /> 
    <button id=""update"">Zaktualizuj</button>

    <div class=""body"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        Imię
                    </th>
                    <th>
                        Nazwisko
                    </th>
                    <th>
                        Brygadzista
                    </th>
                    <th>
                        Stawka godzinowa
                    </th>
                    <th>
                        Podstawa
                    </th>
                    <th>
                        Premia
                    </th>
                    <th>
                        Całość
                    </th>
                </tr>
            </thead>

            <tbody id=""em");
            WriteLiteral(@"ployeesTable"">
            </tbody>

            <tfoot>
                <tr>
                    <th>Suma</th>
                    <th colspan=""3""></th>
                    <th id=""baseSum""></th>
                    <th id=""bonusSum""></th>
                    <th id=""totalSum""></th>
                </tr>
            </tfoot>
        </table>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24364e7e855e84e6fcbe3a7a43eb2c4cc4b6a6875607", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
