#pragma checksum "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6218fff6789bf5538b50b6ad9ec6debd5d4d33a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Matches_TopMatches), @"mvc.1.0.view", @"/Views/Matches/TopMatches.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Matches/TopMatches.cshtml", typeof(AspNetCore.Views_Matches_TopMatches))]
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
#line 1 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\_ViewImports.cshtml"
using Aplikacija_za_kladenje;

#line default
#line hidden
#line 2 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\_ViewImports.cshtml"
using Aplikacija_za_kladenje.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6218fff6789bf5538b50b6ad9ec6debd5d4d33a1", @"/Views/Matches/TopMatches.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f94274d7b13490bb6fd81531f10b10f620f693cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Matches_TopMatches : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Aplikacija_za_kladenje.Models.TopMatchesViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(71, 11, true);
            WriteLiteral("\r\n<p>\r\n    ");
            EndContext();
            BeginContext(82, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6218fff6789bf5538b50b6ad9ec6debd5d4d33a13746", async() => {
                BeginContext(105, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(119, 610, true);
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>

            <th>
                Home Team
            </th>
            <th>
                Away Team
            </th>
            <th>
                1
            </th>
            <th>
                X
            </th>
            <th>
                2
            </th>
            <th>
                1X
            </th>
            <th>
                X2
            </th>
            <th>
                12
            </th>
            <th>

            </th>
        </tr>
    </thead>
    <tbody>

");
            EndContext();
#line 41 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
         foreach (var item in Model)
        {
        

#line default
#line hidden
#line 43 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
         using (Html.BeginForm("Bet", "BetSlips", new { MatchId = item.Id, top=true}, FormMethod.Post))
            {

#line default
#line hidden
            BeginContext(898, 50, true);
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(949, 17, false);
#line 48 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
           Write(item.HomeTeamName);

#line default
#line hidden
            EndContext();
            BeginContext(966, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1022, 17, false);
#line 51 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
           Write(item.AwayTeamName);

#line default
#line hidden
            EndContext();
            BeginContext(1039, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 1114, "", 1126, 1);
#line 54 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
WriteAttributeValue("", 1118, item.Id, 1118, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1126, 15, true);
            WriteLiteral(" , name=\"value\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 1141, "", 1156, 1);
#line 54 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
WriteAttributeValue("", 1148, item._1, 1148, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1156, 100, true);
            WriteLiteral(" class=\"btn btn-primary\">\r\n            </td>\r\n            <td>\r\n                <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 1256, "", 1268, 1);
#line 57 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
WriteAttributeValue("", 1260, item.Id, 1260, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1268, 13, true);
            WriteLiteral(" name=\"value\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 1281, "", 1296, 1);
#line 57 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
WriteAttributeValue("", 1288, item._X, 1288, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1296, 100, true);
            WriteLiteral(" class=\"btn btn-primary\">\r\n            </td>\r\n            <td>\r\n                <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 1396, "", 1408, 1);
#line 60 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
WriteAttributeValue("", 1400, item.Id, 1400, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1408, 13, true);
            WriteLiteral(" name=\"value\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 1421, "", 1436, 1);
#line 60 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
WriteAttributeValue("", 1428, item._2, 1428, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1436, 100, true);
            WriteLiteral(" class=\"btn btn-primary\">\r\n            </td>\r\n            <td>\r\n                <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 1536, "", 1548, 1);
#line 63 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
WriteAttributeValue("", 1540, item.Id, 1540, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1548, 13, true);
            WriteLiteral(" name=\"value\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 1561, "", 1577, 1);
#line 63 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
WriteAttributeValue("", 1568, item._1X, 1568, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1577, 100, true);
            WriteLiteral(" class=\"btn btn-primary\">\r\n            </td>\r\n            <td>\r\n                <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 1677, "", 1689, 1);
#line 66 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
WriteAttributeValue("", 1681, item.Id, 1681, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1689, 13, true);
            WriteLiteral(" name=\"value\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 1702, "", 1718, 1);
#line 66 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
WriteAttributeValue("", 1709, item._X2, 1709, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1718, 100, true);
            WriteLiteral(" class=\"btn btn-primary\">\r\n            </td>\r\n            <td>\r\n                <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 1818, "", 1830, 1);
#line 69 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
WriteAttributeValue("", 1822, item.Id, 1822, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1830, 13, true);
            WriteLiteral(" name=\"value\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 1843, "", 1859, 1);
#line 69 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
WriteAttributeValue("", 1850, item._12, 1850, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1859, 63, true);
            WriteLiteral(" class=\"btn btn-primary\">\r\n            </td>\r\n\r\n        </tr>\r\n");
            EndContext();
#line 73 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
            }

#line default
#line hidden
#line 73 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
             

        }

#line default
#line hidden
            BeginContext(1950, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Aplikacija_za_kladenje.Models.TopMatchesViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
