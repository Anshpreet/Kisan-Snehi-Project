#pragma checksum "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerProfile\DisplayAllCrops.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1a9cda0e61b8babf7e8d106cde7596695d33321"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FarmerProfile_DisplayAllCrops), @"mvc.1.0.view", @"/Views/FarmerProfile/DisplayAllCrops.cshtml")]
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
#line 1 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerProfile\DisplayAllCrops.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerProfile\DisplayAllCrops.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1a9cda0e61b8babf7e8d106cde7596695d33321", @"/Views/FarmerProfile/DisplayAllCrops.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ceaecbe03b114244d02826863a55222581e4d9f", @"/Views/_ViewImports.cshtml")]
    public class Views_FarmerProfile_DisplayAllCrops : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<KisaanSnehiWebApplication.Models.CropModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:200px; height:170px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerProfile\DisplayAllCrops.cshtml"
  
    ViewData["Title"] = "DisplayAllCrops";
    Layout = "~/Views/Shared/_FarmerLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1a9cda0e61b8babf7e8d106cde7596695d333215415", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">


        $(function () {
            var PlaceHolderElement = $('#PlaceHolderHere')
            $('button[data-toggle=""ajax-modal""]').click(function (event) {

                var url = $(this).data('url');
                var decodedUrl = decodeURIComponent(url);
                $.get(decodedUrl).done(function (data) {
                    PlaceHolderElement.html(data);
                    PlaceHolderElement.find('.modal').modal('show');
                })
            })

            PlaceHolderElement.on('click', '[data-dismiss=""modal""]', function (event) {

                PlaceHolderElement.find('.modal').modal('hide');

            })

        })

    </script>

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
            WriteLiteral("\r\n\r\n<section id=\"DisplayCrops\" class=\"d-flex flex-column justify-content-center align-items-center\" style=\"margin-left:320px \">\r\n    <p style=\"text-align:center\">\r\n\r\n        <div id=\"PlaceHolderHere\"></div>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerProfile\DisplayAllCrops.cshtml"
         using (Html.BeginForm("DisplayAllCrops", "FarmerProfile", FormMethod.Get))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"ajax-modal\"\r\n                    data-target=\"#AddCrop\" data-url=\"");
#nullable restore
#line 52 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerProfile\DisplayAllCrops.cshtml"
                                                Write(Url.Action($"AddCrop"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" style=\"background-color:forestgreen\">\r\n                Add Crop\r\n            </button>\r\n");
#nullable restore
#line 55 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerProfile\DisplayAllCrops.cshtml"
       Write(Html.TextBox("searchName", null, new { style = "height:36px; ", placeholder = "Search name..." }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button type=\"submit\" class=\"btn btn-primary\" style=\"background-color:forestgreen;color:white;\">\r\n                <i class=\"icofont icofont-search-2\"></i>\r\n            </button>\r\n            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1997, "\"", 2086, 4);
            WriteAttributeValue("", 2007, "location.href=\'", 2007, 15, true);
#nullable restore
#line 59 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerProfile\DisplayAllCrops.cshtml"
WriteAttributeValue("", 2022, Url.Action("GetPurchasedCrops", "FarmerProfile"), 2022, 49, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2071, "\';return", 2071, 8, true);
            WriteAttributeValue(" ", 2079, "false;", 2080, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\"\r\n                    style=\"background-color:forestgreen; color:white;\">\r\n                Selling History\r\n            </button>\r\n");
#nullable restore
#line 71 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerProfile\DisplayAllCrops.cshtml"
        

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </p>\r\n    <br />\r\n\r\n\r\n    <table class=\"table\">\r\n        <thead></thead>\r\n");
#nullable restore
#line 80 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerProfile\DisplayAllCrops.cshtml"
          
            int i = 5;
            if (Model.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("<tr>\r\n                    ");
            WriteLiteral("<td colspan=\"3\" style=\"color:forestgreen; text-align:center;\">No data found.</td>\r\n                ");
            WriteLiteral("</tr>\r\n");
#nullable restore
#line 87 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerProfile\DisplayAllCrops.cshtml"
            }
            else
            {
                foreach (var item in Model)
                {
                    if (i == 5 || i == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("<tr>\r\n");
#nullable restore
#line 95 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerProfile\DisplayAllCrops.cshtml"
                        }



#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"align-items:center\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c1a9cda0e61b8babf7e8d106cde7596695d3332111531", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 99 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerProfile\DisplayAllCrops.cshtml"
                           WriteLiteral("~/CropImages/" + item.Image);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 99 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerProfile\DisplayAllCrops.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <br />\r\n                            ");
#nullable restore
#line 101 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerProfile\DisplayAllCrops.cshtml"
                       Write(Html.Label("Crop Name :",null, new { @style= "font-weight:bold;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 101 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerProfile\DisplayAllCrops.cshtml"
                                                                                            Write(Html.DisplayFor(modelItem => item.CropName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                            ");
#nullable restore
#line 102 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerProfile\DisplayAllCrops.cshtml"
                       Write(Html.Label("Price (per kg) :", null, new { @style = "font-weight:bold;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Rs. ");
#nullable restore
#line 102 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerProfile\DisplayAllCrops.cshtml"
                                                                                                       Write(Html.DisplayFor(modelItem => item.CropPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <br />
                           

                            <button type=""button"" class=""btn btn-primary"" style=""background-color:white;color:forestgreen;border-color:white"" data-toggle=""ajax-modal""
                                    data-target=""#EditCrop"" data-url=""");
#nullable restore
#line 106 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerProfile\DisplayAllCrops.cshtml"
                                                                 Write(Url.Action($"EditCrop/{item.CropId}"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                <i class=""icofont-ui-edit""></i>
                            </button>
                            <button type=""button"" class=""btn btn-primary"" style=""background-color:white;color:forestgreen; border-color:white"" data-toggle=""ajax-modal""
                                    data-target=""#CropDetails"" data-url=""");
#nullable restore
#line 110 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerProfile\DisplayAllCrops.cshtml"
                                                                    Write(Url.Action($"CropDetails/{item.CropId}"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                <i class=""bx bx-detail""></i>
                            </button>
                            <button type=""button"" class=""btn btn-primary"" style=""background-color:white;color:forestgreen; border-color:white"" data-toggle=""ajax-modal""
                                    data-target=""#DeleteCrop"" data-url=""");
#nullable restore
#line 114 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerProfile\DisplayAllCrops.cshtml"
                                                                   Write(Url.Action($"DeleteCrop/{item.CropId}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                <i class=\"icofont-delete-alt\"></i>\r\n                            </button>\r\n\r\n\r\n                        </td>\r\n");
#nullable restore
#line 120 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerProfile\DisplayAllCrops.cshtml"
                        i -= 1;

                        if (i == 0)
                        {
                            i = 5;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("</tr>\r\n");
#nullable restore
#line 126 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerProfile\DisplayAllCrops.cshtml"
                    }
                }


            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </table>\r\n\r\n    ");
#nullable restore
#line 136 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerProfile\DisplayAllCrops.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("DisplayAllCrops", new { page }),
        new X.PagedList.Web.Common.PagedListRenderOptionsBase
        {
            DisplayItemSliceAndTotal = true,
            ContainerDivClasses = new[] { "navigation" },
            LiElementClasses = new[] { "page-item" },
            PageClasses = new[] { "page-link" }
        }
        ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</section>\r\n\r\n\r\n\r\n\r\n<script type=\"text/javascript\">\r\n\r\n    $(document).ready(function () {\r\n        $(\'ul.pagination > li.disabled > a\').addClass(\'page-link\');\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<KisaanSnehiWebApplication.Models.CropModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591