#pragma checksum "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0d96b9b9e791f286d04473e9abbeb1b43411204"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bill_Confirm), @"mvc.1.0.view", @"/Views/Bill/Confirm.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0d96b9b9e791f286d04473e9abbeb1b43411204", @"/Views/Bill/Confirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e90093b101f83f068c3326cd49fefb5d4ecfa1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Bill_Confirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WaterBillAppCore.Models.Bill>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://www.payfast.co.za/eng/process"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
  
    ViewData["Title"] = "Confirm";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var imagePath = "~/Images/noimage.jpg";
    if (!string.IsNullOrEmpty(Model.PhotoUrl))
        imagePath = "~/Images/" + Model.PhotoUrl;
   

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Bill Details</h4>\r\n\r\n\r\n\r\n<div class=\"card mb-3\">\r\n    <div class=\"card-header\">\r\n        # ");
#nullable restore
#line 21 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
     Write(Html.DisplayFor(model => model.BillId));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <b>R ");
#nullable restore
#line 21 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
                                                  Write(Model.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
                                                                Write(Model.BillStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n    </div>\r\n\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 25 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
                          Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h5>\r\n\r\n\r\n        <p>\r\n            <span class=\"small\">  ");
#nullable restore
#line 29 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
                             Write(Html.DisplayNameFor(model => model.Usage));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>  <br>\r\n            ");
#nullable restore
#line 30 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
       Write(Model.Usage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <hr>\r\n        </p>\r\n\r\n        <p>\r\n            <span class=\"small\">  ");
#nullable restore
#line 35 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
                             Write(Html.DisplayNameFor(model => model.AccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>  <br>\r\n            ");
#nullable restore
#line 36 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
       Write(Model.AccountNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <hr>\r\n        </p>\r\n\r\n        <p>\r\n            <span class=\"small\">  ");
#nullable restore
#line 41 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
                             Write(Html.DisplayNameFor(model => model.CustomerAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>  <br>\r\n            ");
#nullable restore
#line 42 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
       Write(Model.CustomerAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <hr>\r\n        </p>\r\n\r\n\r\n        <p>\r\n            <span class=\"small\">  ");
#nullable restore
#line 48 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
                             Write(Html.DisplayNameFor(model => model.CustomerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>  <br>\r\n            ");
#nullable restore
#line 49 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
       Write(Model.CustomerEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <hr>\r\n        </p>\r\n\r\n        <p>\r\n            <span class=\"small\">  ");
#nullable restore
#line 54 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
                             Write(Html.DisplayNameFor(model => model.CustomerPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>  <br>\r\n            ");
#nullable restore
#line 55 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
       Write(Model.CustomerPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <hr>\r\n        </p>\r\n\r\n        <p>\r\n            <span class=\"small\">  ");
#nullable restore
#line 60 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
                             Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>  <br>\r\n            ");
#nullable restore
#line 61 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
       Write(Model.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <hr>\r\n        </p>\r\n\r\n\r\n    </div>\r\n\r\n    <div class=\"card-img\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a0d96b9b9e791f286d04473e9abbeb1b4341120410526", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
      WriteLiteral(imagePath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 69 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
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
            WriteLiteral("\r\n    </div>\r\n    <div class=\"card-footer\">\r\n\r\n\r\n");
#nullable restore
#line 74 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
         if (SignInManager.IsSignedIn(User))
        {
            if (User.IsInRole("Customer") && @Model.BillStatus == "Pending Payment")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0d96b9b9e791f286d04473e9abbeb1b4341120413094", async() => {
                WriteLiteral(@"
                    <span>
                        <input type=""hidden"" name=""merchant_id"" value=""18532075"">
                        <input type=""hidden"" name=""merchant_key"" value=""sfdfjuciknw4b"">
                        <input type=""hidden"" name=""return_url""");
                BeginWriteAttribute("value", " value=\"", 2443, "\"", 2501, 2);
                WriteAttributeValue("", 2451, "http://localhost:63919/Bill/BillPaid/", 2451, 37, true);
#nullable restore
#line 82 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
WriteAttributeValue("", 2488, Model.BillId, 2488, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
                WriteLiteral("                        <input type=\"hidden\" name=\"cancel_url\"");
                BeginWriteAttribute("value", " value=\"", 2694, "\"", 2752, 2);
                WriteAttributeValue("", 2702, "http://localhost:63919/Bill/BillPaid/", 2702, 37, true);
#nullable restore
#line 84 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
WriteAttributeValue("", 2739, Model.BillId, 2739, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"hidden\" name=\"notify_url\"");
                BeginWriteAttribute("value", " value=\"", 2818, "\"", 2875, 2);
                WriteAttributeValue("", 2826, "http://localhost:63919/Bill/Confirm/", 2826, 36, true);
#nullable restore
#line 85 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
WriteAttributeValue("", 2862, Model.BillId, 2862, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                        <input type=\"hidden\" name=\"name_first\"");
                BeginWriteAttribute("value", " value=\"", 2943, "\"", 2970, 1);
#nullable restore
#line 87 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
WriteAttributeValue("", 2951, Model.CustomerName, 2951, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"hidden\" name=\"name_last\" value=\"Payment\">\r\n                        <input type=\"hidden\" name=\"email_address\"");
                BeginWriteAttribute("value", " value=\"", 3119, "\"", 3147, 1);
#nullable restore
#line 89 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
WriteAttributeValue("", 3127, Model.CustomerEmail, 3127, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"hidden\" name=\"cell_number\"");
                BeginWriteAttribute("value", " value=\"", 3214, "\"", 3242, 1);
#nullable restore
#line 90 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
WriteAttributeValue("", 3222, Model.CustomerPhone, 3222, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n\r\n                        <input type=\"hidden\" name=\"amount\"");
                BeginWriteAttribute("value", " value=\"", 3308, "\"", 3357, 1);
#nullable restore
#line 93 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
WriteAttributeValue("", 3316, Model.Amount.ToString().Replace(",","."), 3316, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"hidden\" name=\"item_name\"");
                BeginWriteAttribute("value", " value=\"", 3422, "\"", 3448, 1);
#nullable restore
#line 94 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
WriteAttributeValue("", 3430, Model.Description, 3430, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"hidden\" name=\"item_description\"");
                BeginWriteAttribute("value", " value=\"", 3520, "\"", 3546, 1);
#nullable restore
#line 95 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"
WriteAttributeValue("", 3528, Model.Description, 3528, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">


                        <input type=""hidden"" name=""email_confirmation"" value=""1"">
                        <input type=""hidden"" name=""confirmation_address"" value=""Info@vigortech.co.za"">
                    </span>

                    <div class=""form-group"">
                        <button class=""btn btn-primary"" type=""submit"">
                            Proceed to online
                            payments
                        </button>

                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("ngNoForm", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 110 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Bill\Confirm.cshtml"

            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<AppUser> SignInManager { get; private set; }
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
