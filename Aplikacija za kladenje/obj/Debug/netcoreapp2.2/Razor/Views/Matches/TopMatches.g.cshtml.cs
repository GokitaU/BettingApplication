#pragma checksum "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d757d5b6276760b4ea73e4440c57cfea1600c518"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d757d5b6276760b4ea73e4440c57cfea1600c518", @"/Views/Matches/TopMatches.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d757d5b6276760b4ea73e4440c57cfea1600c5183746", async() => {
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
            BeginContext(119, 868, true);
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
#line 42 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
                 foreach (var item in Model)
                {
                    

#line default
#line hidden
#line 44 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
                     using (Html.BeginForm("Bet", "BetSlips", new { MatchId = item.Id, top = true }, FormMethod.Post))
                    {


#line default
#line hidden
            BeginContext(1197, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1270, 17, false);
#line 49 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
                   Write(item.HomeTeamName);

#line default
#line hidden
            EndContext();
            BeginContext(1287, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1367, 17, false);
#line 52 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
                   Write(item.AwayTeamName);

#line default
#line hidden
            EndContext();
            BeginContext(1384, 55, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 55 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
                         if (item._1 != 0)
                        {

#line default
#line hidden
            BeginContext(1510, 48, true);
            WriteLiteral("                            <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 1558, "", 1570, 1);
#line 57 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
WriteAttributeValue("", 1562, item.Id, 1562, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1570, 15, true);
            WriteLiteral(" , name=\"value\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 1585, "", 1600, 1);
#line 57 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
WriteAttributeValue("", 1592, item._1, 1592, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1600, 27, true);
            WriteLiteral(" class=\"btn btn-primary\">\r\n");
            EndContext();
#line 58 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
                        }

#line default
#line hidden
            BeginContext(1654, 53, true);
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 61 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
                         if (item._X != 0)
                        {

#line default
#line hidden
            BeginContext(1778, 44, true);
            WriteLiteral("                        <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 1822, "", 1834, 1);
#line 63 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
WriteAttributeValue("", 1826, item.Id, 1826, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1834, 13, true);
            WriteLiteral(" name=\"value\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 1847, "", 1862, 1);
#line 63 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
WriteAttributeValue("", 1854, item._X, 1854, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1862, 27, true);
            WriteLiteral(" class=\"btn btn-primary\">\r\n");
            EndContext();
#line 64 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
                        }

#line default
#line hidden
            BeginContext(1916, 53, true);
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 67 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
                         if (item._2 != 0)
                        {

#line default
#line hidden
            BeginContext(2040, 44, true);
            WriteLiteral("                        <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 2084, "", 2096, 1);
#line 69 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
WriteAttributeValue("", 2088, item.Id, 2088, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2096, 13, true);
            WriteLiteral(" name=\"value\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 2109, "", 2124, 1);
#line 69 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
WriteAttributeValue("", 2116, item._2, 2116, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2124, 27, true);
            WriteLiteral(" class=\"btn btn-primary\">\r\n");
            EndContext();
#line 70 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
                        }

#line default
#line hidden
            BeginContext(2178, 53, true);
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 73 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
                         if (item._1X != 0)
                        {

#line default
#line hidden
            BeginContext(2303, 44, true);
            WriteLiteral("                        <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 2347, "", 2359, 1);
#line 75 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
WriteAttributeValue("", 2351, item.Id, 2351, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2359, 13, true);
            WriteLiteral(" name=\"value\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 2372, "", 2388, 1);
#line 75 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
WriteAttributeValue("", 2379, item._1X, 2379, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2388, 27, true);
            WriteLiteral(" class=\"btn btn-primary\">\r\n");
            EndContext();
#line 76 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
                        }

#line default
#line hidden
            BeginContext(2442, 53, true);
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 79 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
                         if (item._X2 != 0)
                        {

#line default
#line hidden
            BeginContext(2567, 44, true);
            WriteLiteral("                        <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 2611, "", 2623, 1);
#line 81 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
WriteAttributeValue("", 2615, item.Id, 2615, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2623, 13, true);
            WriteLiteral(" name=\"value\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 2636, "", 2652, 1);
#line 81 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
WriteAttributeValue("", 2643, item._X2, 2643, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2652, 27, true);
            WriteLiteral(" class=\"btn btn-primary\">\r\n");
            EndContext();
#line 82 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
                        }

#line default
#line hidden
            BeginContext(2706, 53, true);
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 85 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
                         if (item._12 != 0)
                        {

#line default
#line hidden
            BeginContext(2831, 44, true);
            WriteLiteral("                        <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("id", " id=", 2875, "", 2887, 1);
#line 87 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
WriteAttributeValue("", 2879, item.Id, 2879, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2887, 13, true);
            WriteLiteral(" name=\"value\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 2900, "", 2916, 1);
#line 87 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
WriteAttributeValue("", 2907, item._12, 2907, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2916, 27, true);
            WriteLiteral(" class=\"btn btn-primary\">\r\n");
            EndContext();
#line 88 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
                        }

#line default
#line hidden
            BeginContext(2970, 52, true);
            WriteLiteral("                    </td>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 92 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
                    }

#line default
#line hidden
#line 92 "C:\Users\Ante\Documents\Visual Studio 2017\Projects\Aplikacija za kladenje\Aplikacija za kladenje\Views\Matches\TopMatches.cshtml"
                     

                }

#line default
#line hidden
            BeginContext(3066, 40, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
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
