#pragma checksum "C:\Users\Madina\source\repos\WebApplication1\WebApplication1\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0833243b878136d763dc305720291e4b95e5e00d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movies/Index.cshtml", typeof(AspNetCore.Views_Movies_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0833243b878136d763dc305720291e4b95e5e00d", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Models.Movies.Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Madina\source\repos\WebApplication1\WebApplication1\Views\Movies\Index.cshtml"
  
    ViewData["Title"] = "Movies";

#line default
#line hidden
            BeginContext(101, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(103, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8377165670154ed9aa9b767fb9de9b91", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(129, 169, true);
            WriteLiteral("\r\n\r\n\r\n<h1>Index</h1>\r\n\r\n\r\n<table class=\"table is-bordered is-striped is-narrow is-hoverable is-fullwidth\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(299, 38, false);
#line 17 "C:\Users\Madina\source\repos\WebApplication1\WebApplication1\Views\Movies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(337, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(393, 42, false);
#line 20 "C:\Users\Madina\source\repos\WebApplication1\WebApplication1\Views\Movies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Poster));

#line default
#line hidden
            EndContext();
            BeginContext(435, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(491, 40, false);
#line 23 "C:\Users\Madina\source\repos\WebApplication1\WebApplication1\Views\Movies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(531, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(587, 42, false);
#line 26 "C:\Users\Madina\source\repos\WebApplication1\WebApplication1\Views\Movies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
            EndContext();
            BeginContext(629, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(685, 41, false);
#line 29 "C:\Users\Madina\source\repos\WebApplication1\WebApplication1\Views\Movies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(726, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(782, 45, false);
#line 32 "C:\Users\Madina\source\repos\WebApplication1\WebApplication1\Views\Movies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(827, 65, true);
            WriteLiteral("\r\n            </th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 38 "C:\Users\Madina\source\repos\WebApplication1\WebApplication1\Views\Movies\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(941, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1002, 37, false);
#line 42 "C:\Users\Madina\source\repos\WebApplication1\WebApplication1\Views\Movies\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1106, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5421d93548904415adc5d26d5093edb8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#line 45 "C:\Users\Madina\source\repos\WebApplication1\WebApplication1\Views\Movies\Index.cshtml"
                  WriteLiteral(item.Poster);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 45 "C:\Users\Madina\source\repos\WebApplication1\WebApplication1\Views\Movies\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1156, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1224, 39, false);
#line 48 "C:\Users\Madina\source\repos\WebApplication1\WebApplication1\Views\Movies\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1263, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1331, 41, false);
#line 51 "C:\Users\Madina\source\repos\WebApplication1\WebApplication1\Views\Movies\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Author));

#line default
#line hidden
            EndContext();
            BeginContext(1372, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1440, 40, false);
#line 54 "C:\Users\Madina\source\repos\WebApplication1\WebApplication1\Views\Movies\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(1480, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1548, 44, false);
#line 57 "C:\Users\Madina\source\repos\WebApplication1\WebApplication1\Views\Movies\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(1592, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 60 "C:\Users\Madina\source\repos\WebApplication1\WebApplication1\Views\Movies\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1647, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Models.Movies.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
