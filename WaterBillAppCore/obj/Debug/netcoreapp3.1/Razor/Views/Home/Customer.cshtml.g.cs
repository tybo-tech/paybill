#pragma checksum "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Home\Customer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7b7152275c0eef6b69271a8bcb9157754f5375c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Customer), @"mvc.1.0.view", @"/Views/Home/Customer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7b7152275c0eef6b69271a8bcb9157754f5375c", @"/Views/Home/Customer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e90093b101f83f068c3326cd49fefb5d4ecfa1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Customer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Home\Customer.cshtml"
  
    ViewData["Title"] = "Customer";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div class=""container mt-2"">
        <h4 class=""p-5 text-center"">Customer portal</h4>

        <div class=""row"">
            <a  href=""/Bill/Create"" class=""col-md-3 col-sm-6 item"">
                <div class=""card cardhover item-card cursor-pointer card-block p-2 pointer-event"">
                    <h5 class=""item-card-title text-center p-1"">Bills</h5>
                    <p class=""text-center"" >Click here to pay</p>
                </div>
            </a>

            <a  href=""/Query/Create"" class=""col-md-3 col-sm-6 item"">
                <div class=""card cardhover cursor-pointer item-card card-block p-2 pointer-event"""">
                    <h5 class=""item-card-title  text-center p-1"">Queries</h5>
                    <p class="" text-center"">Click here to log a query</p>
                </div>
            </a>



        </div>

    </div>



");
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
