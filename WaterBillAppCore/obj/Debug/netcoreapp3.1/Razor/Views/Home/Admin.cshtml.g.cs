#pragma checksum "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Home\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52cbe9233a634b92062bec4088d5d91cc4f9b0fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Admin), @"mvc.1.0.view", @"/Views/Home/Admin.cshtml")]
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
#line 1 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\_ViewImports.cshtml"
using WaterBillAppCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\_ViewImports.cshtml"
using WaterBillAppCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52cbe9233a634b92062bec4088d5d91cc4f9b0fc", @"/Views/Home/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e90093b101f83f068c3326cd49fefb5d4ecfa1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Home\Admin.cshtml"
  
    ViewData["Title"] = "Admin";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<div class=""container mt-2"">
    <h4 class=""p-5 text-center"">Admin portal</h4>

    <div class=""row"">


        <a href=""/Bill"" class=""col-md-3 col-sm-6 item"">
            <div class=""card cardhover item-card cursor-pointer card-block p-2 pointer-event"">
                <h5 class=""item-card-title text-center p-1"">Bills</h5>
                <p class=""text-center"">Click here to pay</p>
            </div>
        </a>





        <a href=""/Query"" class=""col-md-3 col-sm-6 item"">
            <div class=""card cardhover item-card cursor-pointer card-block p-2 pointer-event"">
                <h5 class=""item-card-title text-center p-1"">Customer Queries</h5>
                <p class=""text-center"">Click here to pay</p>
            </div>
        </a>


        <a href=""/Settings"" class=""col-md-3 col-sm-6 item"">
            <div class=""card cardhover item-card cursor-pointer card-block p-2 pointer-event"">
                <h5 class=""item-card-title text-center p-1"">Settings</h5>
      ");
            WriteLiteral("          <p class=\"text-center\">Click here to pay</p>\r\n            </div>\r\n        </a>\r\n\r\n\r\n\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n");
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
