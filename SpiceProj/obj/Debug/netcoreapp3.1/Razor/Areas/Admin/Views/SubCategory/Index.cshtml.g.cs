#pragma checksum "D:\Users\b.mirza\source\repos\SpiceProj\SpiceProj\Areas\Admin\Views\SubCategory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c94b8a7e77fd33a6cc1c27e1f795f3d50d553e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SubCategory_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/SubCategory/Index.cshtml")]
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
#line 1 "D:\Users\b.mirza\source\repos\SpiceProj\SpiceProj\Areas\Admin\Views\_ViewImports.cshtml"
using SpiceProj;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\b.mirza\source\repos\SpiceProj\SpiceProj\Areas\Admin\Views\_ViewImports.cshtml"
using SpiceProj.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c94b8a7e77fd33a6cc1c27e1f795f3d50d553e5", @"/Areas/Admin/Views/SubCategory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0147dd7ab9f335f25f20b20d770963024ae9aef", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_SubCategory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SubCategory>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CreateButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Users\b.mirza\source\repos\SpiceProj\SpiceProj\Areas\Admin\Views\SubCategory\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<br />

<div class=""border backgroundWhite"">
    <div class=""row"">
        <div class=""col-6"">
            <h2 class=""text-info"">
                Category List
            </h2>
        </div>

        <div class=""col-6 text-right"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3c94b8a7e77fd33a6cc1c27e1f795f3d50d553e54333", async() => {
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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <div>\r\n");
#nullable restore
#line 24 "D:\Users\b.mirza\source\repos\SpiceProj\SpiceProj\Areas\Admin\Views\SubCategory\Index.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table class=\"table table-striped border\">\r\n                <tr class=\"table-secondary\">\r\n                    <th>\r\n                        ");
#nullable restore
#line 29 "D:\Users\b.mirza\source\repos\SpiceProj\SpiceProj\Areas\Admin\Views\SubCategory\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 32 "D:\Users\b.mirza\source\repos\SpiceProj\SpiceProj\Areas\Admin\Views\SubCategory\Index.cshtml"
                   Write(Html.DisplayNameFor(m => m.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n\r\n                    </th>\r\n        \r\n");
#nullable restore
#line 38 "D:\Users\b.mirza\source\repos\SpiceProj\SpiceProj\Areas\Admin\Views\SubCategory\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "D:\Users\b.mirza\source\repos\SpiceProj\SpiceProj\Areas\Admin\Views\SubCategory\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 45 "D:\Users\b.mirza\source\repos\SpiceProj\SpiceProj\Areas\Admin\Views\SubCategory\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3c94b8a7e77fd33a6cc1c27e1f795f3d50d553e57714", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 48 "D:\Users\b.mirza\source\repos\SpiceProj\SpiceProj\Areas\Admin\Views\SubCategory\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 51 "D:\Users\b.mirza\source\repos\SpiceProj\SpiceProj\Areas\Admin\Views\SubCategory\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </table>\r\n");
#nullable restore
#line 54 "D:\Users\b.mirza\source\repos\SpiceProj\SpiceProj\Areas\Admin\Views\SubCategory\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>no subcategory exists</p>\r\n");
#nullable restore
#line 58 "D:\Users\b.mirza\source\repos\SpiceProj\SpiceProj\Areas\Admin\Views\SubCategory\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SubCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591