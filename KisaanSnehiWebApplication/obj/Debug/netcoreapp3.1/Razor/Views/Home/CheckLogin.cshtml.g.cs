#pragma checksum "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\Home\CheckLogin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f9cf4e283f445c1dc2e240576a13e575b9c665f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CheckLogin), @"mvc.1.0.view", @"/Views/Home/CheckLogin.cshtml")]
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
#line 1 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\_ViewImports.cshtml"
using KisaanSnehiWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\_ViewImports.cshtml"
using KisaanSnehiWebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f9cf4e283f445c1dc2e240576a13e575b9c665f", @"/Views/Home/CheckLogin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ceaecbe03b114244d02826863a55222581e4d9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CheckLogin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\Home\CheckLogin.cshtml"
     if (ViewBag.ErrorMessage != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script type=\"text/javascript\">\r\n\r\n            window.onload = function () {\r\n                alert(\"Invalid User name or password\");\r\n                window.location.href = \"LoginOrSignUp\";\r\n            };\r\n        </script>\r\n");
#nullable restore
#line 14 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\Home\CheckLogin.cshtml"

    }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
