#pragma checksum "D:\GULIT\Opportunity\moonlay\MoonlayStore\MoonlayStore\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42a4bf19248cd70c9e950ca324ee15dc0e15c4ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Detail.cshtml", typeof(AspNetCore.Views_Product_Detail))]
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
#line 1 "D:\GULIT\Opportunity\moonlay\MoonlayStore\MoonlayStore\Views\_ViewImports.cshtml"
using MoonlayStore;

#line default
#line hidden
#line 2 "D:\GULIT\Opportunity\moonlay\MoonlayStore\MoonlayStore\Views\_ViewImports.cshtml"
using MoonlayStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42a4bf19248cd70c9e950ca324ee15dc0e15c4ee", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e25e7d18e2548d5f88e00bc1ae1fdf8933b3327e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MoonlayStore.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\GULIT\Opportunity\moonlay\MoonlayStore\MoonlayStore\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(127, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(150, 139, true);
            WriteLiteral("<br />\r\n<div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <div class=\"thumbnail\" id=\"imgTag\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 289, "\"", 335, 1);
#line 14 "D:\GULIT\Opportunity\moonlay\MoonlayStore\MoonlayStore\Views\Product\Detail.cshtml"
WriteAttributeValue("", 295, Html.DisplayFor(model=>model.images[0]), 295, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(336, 64, true);
            WriteLiteral(" alt=\"...\">\r\n            </div>\r\n            <div class=\"row\">\r\n");
            EndContext();
#line 17 "D:\GULIT\Opportunity\moonlay\MoonlayStore\MoonlayStore\Views\Product\Detail.cshtml"
                 foreach (var img in Model.images)
                {
                   var i = 0;

#line default
#line hidden
            BeginContext(502, 98, true);
            WriteLiteral("                <div class=\"col-lg-2\">\r\n                    <div class=\"thumbnail over\" data-url=\"");
            EndContext();
            BeginContext(601, 3, false);
#line 21 "D:\GULIT\Opportunity\moonlay\MoonlayStore\MoonlayStore\Views\Product\Detail.cshtml"
                                                     Write(img);

#line default
#line hidden
            EndContext();
            BeginContext(604, 35, true);
            WriteLiteral("\" onclick=\"img_selected(this)\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 639, "\"", 677, 1);
#line 21 "D:\GULIT\Opportunity\moonlay\MoonlayStore\MoonlayStore\Views\Product\Detail.cshtml"
WriteAttributeValue("", 645, Html.DisplayFor(modelItem=>img), 645, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(678, 54, true);
            WriteLiteral(" alt=\"...\" width=\"50\"></div>\r\n                </div>\r\n");
            EndContext();
#line 23 "D:\GULIT\Opportunity\moonlay\MoonlayStore\MoonlayStore\Views\Product\Detail.cshtml"
                    i++;
                }

#line default
#line hidden
            BeginContext(777, 84, true);
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <h4>");
            EndContext();
            BeginContext(862, 37, false);
#line 28 "D:\GULIT\Opportunity\moonlay\MoonlayStore\MoonlayStore\Views\Product\Detail.cshtml"
           Write(Html.DisplayFor(model => model.title));

#line default
#line hidden
            EndContext();
            BeginContext(899, 56, true);
            WriteLiteral("</h4>\r\n            <span class=\"label label-success\">by ");
            EndContext();
            BeginContext(956, 37, false);
#line 29 "D:\GULIT\Opportunity\moonlay\MoonlayStore\MoonlayStore\Views\Product\Detail.cshtml"
                                            Write(Html.DisplayFor(model => model.brand));

#line default
#line hidden
            EndContext();
            BeginContext(993, 57, true);
            WriteLiteral("</span> |\r\n            <span class=\"label label-warning\">");
            EndContext();
            BeginContext(1051, 45, false);
#line 30 "D:\GULIT\Opportunity\moonlay\MoonlayStore\MoonlayStore\Views\Product\Detail.cshtml"
                                         Write(Html.DisplayFor(model => model.reviews.stars));

#line default
#line hidden
            EndContext();
            BeginContext(1096, 120, true);
            WriteLiteral(" <span class=\"glyphicon glyphicon-star\" aria-hidden=\"true\"></span></span> |\r\n            <span class=\"label label-info\">");
            EndContext();
            BeginContext(1217, 70, false);
#line 31 "D:\GULIT\Opportunity\moonlay\MoonlayStore\MoonlayStore\Views\Product\Detail.cshtml"
                                      Write(String.Format("{0:n0}", @Convert.ToInt32(Model.reviews.total_reviews)));

#line default
#line hidden
            EndContext();
            BeginContext(1287, 82, true);
            WriteLiteral("  ratings</span>\r\n\r\n            <br /><br />\r\n\r\n            <h4>\r\n                ");
            EndContext();
            BeginContext(1370, 47, false);
#line 36 "D:\GULIT\Opportunity\moonlay\MoonlayStore\MoonlayStore\Views\Product\Detail.cshtml"
           Write(Html.DisplayFor(model => model.prices.currency));

#line default
#line hidden
            EndContext();
            BeginContext(1417, 66, true);
            WriteLiteral("\r\n                <span style=\"text-decoration-line:line-through\">");
            EndContext();
            BeginContext(1484, 53, false);
#line 37 "D:\GULIT\Opportunity\moonlay\MoonlayStore\MoonlayStore\Views\Product\Detail.cshtml"
                                                           Write(Html.DisplayFor(model => model.prices.previous_price));

#line default
#line hidden
            EndContext();
            BeginContext(1537, 49, true);
            WriteLiteral("</span>\r\n                <span style=\"color:red\">");
            EndContext();
            BeginContext(1587, 52, false);
#line 38 "D:\GULIT\Opportunity\moonlay\MoonlayStore\MoonlayStore\Views\Product\Detail.cshtml"
                                   Write(Html.DisplayFor(model => model.prices.current_price));

#line default
#line hidden
            EndContext();
            BeginContext(1639, 59, true);
            WriteLiteral("</span>\r\n                <span class=\"label label-default\">");
            EndContext();
            BeginContext(1699, 40, false);
#line 39 "D:\GULIT\Opportunity\moonlay\MoonlayStore\MoonlayStore\Views\Product\Detail.cshtml"
                                             Write(Html.DisplayFor(model => model.category));

#line default
#line hidden
            EndContext();
            BeginContext(1739, 42, true);
            WriteLiteral("</span>\r\n            </h4>\r\n\r\n            ");
            EndContext();
            BeginContext(1782, 55, false);
#line 42 "D:\GULIT\Opportunity\moonlay\MoonlayStore\MoonlayStore\Views\Product\Detail.cshtml"
       Write(Html.Raw(Model.description.Replace("\n", "<br/><br/>")));

#line default
#line hidden
            EndContext();
            BeginContext(1837, 18, true);
            WriteLiteral("\r\n\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1855, "\"", 1904, 1);
#line 44 "D:\GULIT\Opportunity\moonlay\MoonlayStore\MoonlayStore\Views\Product\Detail.cshtml"
WriteAttributeValue("", 1862, Html.DisplayFor(model => model.full_link), 1862, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1905, 17, true);
            WriteLiteral(" target=\"_blank\">");
            EndContext();
            BeginContext(1923, 41, false);
#line 44 "D:\GULIT\Opportunity\moonlay\MoonlayStore\MoonlayStore\Views\Product\Detail.cshtml"
                                                                            Write(Html.DisplayFor(model => model.full_link));

#line default
#line hidden
            EndContext();
            BeginContext(1964, 78, true);
            WriteLiteral("</a>\r\n            \r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n   \r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2042, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f828e42097c34a01ab0b3fb67c4be3e7", async() => {
                BeginContext(2064, 4, true);
                WriteLiteral("Back");
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
            BeginContext(2072, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoonlayStore.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
