#pragma checksum "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f72dab1d2b778c23b57e0297d6169e2f6afe6f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bill_Details), @"mvc.1.0.view", @"/Views/Bill/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f72dab1d2b778c23b57e0297d6169e2f6afe6f5", @"/Views/Bill/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e90093b101f83f068c3326cd49fefb5d4ecfa1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Bill_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WaterBillAppCore.Models.Bill>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var imagePath = "~/Images/" + (Model.PhotoUrl ?? "noimage.jpg");


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n<div class=\"row\">\r\n    <div class=\"col-sm-6\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7f72dab1d2b778c23b57e0297d6169e2f6afe6f54691", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
      WriteLiteral(imagePath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 13 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div>\r\n    <h4>Bill</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 47 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BillNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 56 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayFor(model => model.BillNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 59 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 62 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 65 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AmountPaid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 68 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayFor(model => model.AmountPaid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 71 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PaymentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 74 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayFor(model => model.PaymentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 77 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 80 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayFor(model => model.DueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 83 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 86 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 89 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastModifiedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 92 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastModifiedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 95 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BillStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 98 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayFor(model => model.BillStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 101 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PrevReading));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 104 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayFor(model => model.PrevReading));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 107 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CurrentReading));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 110 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayFor(model => model.CurrentReading));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 113 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Usage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 116 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
       Write(Html.DisplayFor(model => model.Usage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f72dab1d2b778c23b57e0297d6169e2f6afe6f517845", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Details.cshtml"
                           WriteLiteral(Model.BillId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f72dab1d2b778c23b57e0297d6169e2f6afe6f520011", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WaterBillAppCore.Models.Bill> Html { get; private set; }
    }
}
#pragma warning restore 1591