#pragma checksum "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerFertilizer\DisplayCartContents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4a2d18335adeac65f4135e39d664b14e3ad11aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FarmerFertilizer_DisplayCartContents), @"mvc.1.0.view", @"/Views/FarmerFertilizer/DisplayCartContents.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4a2d18335adeac65f4135e39d664b14e3ad11aa", @"/Views/FarmerFertilizer/DisplayCartContents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ceaecbe03b114244d02826863a55222581e4d9f", @"/Views/_ViewImports.cshtml")]
    public class Views_FarmerFertilizer_DisplayCartContents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KisaanSnehiWebApplication.Models.FertilizerPurchaseModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerFertilizer\DisplayCartContents.cshtml"
  
    ViewData["Title"] = "DisplayCartContents";
    Layout = "~/Views/Shared/_FarmerLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style type=""text/css"">
    .btn {
        background-color: white;
        color: forestgreen;
        border: 2px solid forestgreen;
    }

        .btn:hover {
            background-color: forestgreen;
            color: white;
        }
</style>

<section id=""GetListOfFertilizers"" class=""d-flex flex-column justify-content-center align-items-center"" style=""margin-left:320px"">
    
    <table class=""table"">
        ");
#nullable restore
#line 24 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerFertilizer\DisplayCartContents.cshtml"
   Write(Html.ActionLink("Confirm order", "GenerateBill", "FarmerFertilizer", new { @class = "btn" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <thead>\r\n            <tr>\r\n");
            WriteLiteral("                <th>\r\n                    ");
#nullable restore
#line 31 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerFertilizer\DisplayCartContents.cshtml"
               Write(Html.DisplayNameFor(model => model.FarmerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 34 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerFertilizer\DisplayCartContents.cshtml"
               Write(Html.DisplayNameFor(model => model.TraderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 37 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerFertilizer\DisplayCartContents.cshtml"
               Write(Html.DisplayNameFor(model => model.FertilizerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 40 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerFertilizer\DisplayCartContents.cshtml"
               Write(Html.DisplayNameFor(model => model.FertilizerPurchaseQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 43 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerFertilizer\DisplayCartContents.cshtml"
               Write(Html.DisplayNameFor(model => model.FertilizerBillAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 46 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerFertilizer\DisplayCartContents.cshtml"
               Write(Html.DisplayNameFor(model => model.FertilizerPurchaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 52 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerFertilizer\DisplayCartContents.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 59 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerFertilizer\DisplayCartContents.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FarmerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerFertilizer\DisplayCartContents.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TraderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerFertilizer\DisplayCartContents.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FertilizerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 68 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerFertilizer\DisplayCartContents.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FertilizerPurchaseQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 71 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerFertilizer\DisplayCartContents.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FertilizerBillAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 74 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerFertilizer\DisplayCartContents.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FertilizerPurchaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
            WriteLiteral("                        ");
#nullable restore
#line 79 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerFertilizer\DisplayCartContents.cshtml"
                   Write(Html.ActionLink("Remove", "RemoveFromCart", "FarmerFertilizer", new { id = item.FertilizerId }, new { @class = "btn" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 82 "C:\Users\Anshpreet kaur\source\repos\KisanSnehiNew\KisanSnehiNew\KisaanSnehiWebApplication\Views\FarmerFertilizer\DisplayCartContents.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KisaanSnehiWebApplication.Models.FertilizerPurchaseModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
