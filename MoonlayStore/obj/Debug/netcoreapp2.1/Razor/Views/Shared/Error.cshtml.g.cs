#pragma checksum "D:\GULIT\Opportunity\MoonlayTechnicalTest\MoonlayStore\MoonlayStore\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20ba21efe70b5483484977ee32f3d24c45845be7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "D:\GULIT\Opportunity\MoonlayTechnicalTest\MoonlayStore\MoonlayStore\Views\_ViewImports.cshtml"
using MoonlayStore;

#line default
#line hidden
#line 2 "D:\GULIT\Opportunity\MoonlayTechnicalTest\MoonlayStore\MoonlayStore\Views\_ViewImports.cshtml"
using MoonlayStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20ba21efe70b5483484977ee32f3d24c45845be7", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e25e7d18e2548d5f88e00bc1ae1fdf8933b3327e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 319, true);
            WriteLiteral(@"
<h3 class=""text-danger"">An error occurred while processing your request.
    The support team is notified and we are working on the fix</h3>
<h5>Please contact us on gulithabibi@mgail.com</h5>
<hr />

<h3>Exception Details:</h3>
<div class=""alert alert-danger"">
    <h5>Exception Path</h5>
    <hr />
    <p>");
            EndContext();
            BeginContext(320, 21, false);
#line 11 "D:\GULIT\Opportunity\MoonlayTechnicalTest\MoonlayStore\MoonlayStore\Views\Shared\Error.cshtml"
  Write(ViewBag.ExceptionPath);

#line default
#line hidden
            EndContext();
            BeginContext(341, 101, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n<div class=\"alert alert-danger\">\r\n    <h5>Exception Message</h5>\r\n    <hr />\r\n    <p>");
            EndContext();
            BeginContext(443, 24, false);
#line 17 "D:\GULIT\Opportunity\MoonlayTechnicalTest\MoonlayStore\MoonlayStore\Views\Shared\Error.cshtml"
  Write(ViewBag.ExceptionMessage);

#line default
#line hidden
            EndContext();
            BeginContext(467, 105, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n<div class=\"alert alert-danger\">\r\n    <h5>Exception Stack Trace</h5>\r\n    <hr />\r\n    <p>");
            EndContext();
            BeginContext(573, 18, false);
#line 23 "D:\GULIT\Opportunity\MoonlayTechnicalTest\MoonlayStore\MoonlayStore\Views\Shared\Error.cshtml"
  Write(ViewBag.StackTrace);

#line default
#line hidden
            EndContext();
            BeginContext(591, 12, true);
            WriteLiteral("</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
