#pragma checksum "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\Admin\GetFarmersList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08a46c1b83c2e250c226e664e6ba382ab174e28a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GetFarmersList), @"mvc.1.0.view", @"/Views/Admin/GetFarmersList.cshtml")]
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
#nullable restore
#line 5 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\Admin\GetFarmersList.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\Admin\GetFarmersList.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08a46c1b83c2e250c226e664e6ba382ab174e28a", @"/Views/Admin/GetFarmersList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ceaecbe03b114244d02826863a55222581e4d9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GetFarmersList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<KisaanSnehiWebApplication.Models.RegistrationModel>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(" \r\n\r\n");
#nullable restore
#line 9 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\Admin\GetFarmersList.cshtml"
  
    ViewData["Title"] = " Farmer's List";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08a46c1b83c2e250c226e664e6ba382ab174e28a4258", async() => {
                WriteLiteral(@"
    <style>

        /* The heart of the matter */

        .horizontal-scrollable > .row {
            white-space: nowrap;
        }

            .horizontal-scrollable > .row > .col-xs-4 {
                display: inline-block;
                float: none;
            }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08a46c1b83c2e250c226e664e6ba382ab174e28a5523", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("\r\n\r\n    <div style=\"margin-left:25%;margin-right:2%; overflow: auto;\">\r\n        <h1> Farmer\'s List</h1>\r\n        <table style=\"overflow: auto;\" class=\"table table-striped table-bordered table-sm\">\r\n            <thead>\r\n                <tr>\r\n\r\n");
                WriteLiteral("                    <th>\r\n                        ");
#nullable restore
#line 43 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\Admin\GetFarmersList.cshtml"
                   Write(Html.DisplayNameFor(model => model.First().Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 46 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\Admin\GetFarmersList.cshtml"
                   Write(Html.DisplayNameFor(model => model.First().EmailId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 49 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\Admin\GetFarmersList.cshtml"
                   Write(Html.DisplayNameFor(model => model.First().PhoneNo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 52 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\Admin\GetFarmersList.cshtml"
                   Write(Html.DisplayNameFor(model => model.First().Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n\r\n                    <th>\r\n                        ");
#nullable restore
#line 56 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\Admin\GetFarmersList.cshtml"
                   Write(Html.DisplayNameFor(model => model.First().RegDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n\r\n                     \r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 63 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\Admin\GetFarmersList.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n\r\n                        <td>\r\n                            ");
#nullable restore
#line 68 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\Admin\GetFarmersList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 71 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\Admin\GetFarmersList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.EmailId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 74 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\Admin\GetFarmersList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PhoneNo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 77 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\Admin\GetFarmersList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
#nullable restore
#line 81 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\Admin\GetFarmersList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.RegDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 86 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\Admin\GetFarmersList.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n        ");
#nullable restore
#line 89 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\Admin\GetFarmersList.cshtml"
   Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("GetFarmersList", "Admin", new { page = page }),
        new X.PagedList.Web.Common.PagedListRenderOptionsBase
        {
            DisplayItemSliceAndTotal = true,
            ContainerDivClasses = new[] { "navigation" },
            LiElementClasses = new[] { "page-item" },
            PageClasses = new[] { "page-link" },
        }
        ));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    </section>\r\n    \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n\r\n        $(document).ready(function () {\r\n            $(\'ul.pagination > li.disabled > a\').addClass(\'page-link\');\r\n        });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<KisaanSnehiWebApplication.Models.RegistrationModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
