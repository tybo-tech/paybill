#pragma checksum "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60e5c5e1f15a02aca69da3c4f4e8dfb7060f61d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Query_Details), @"mvc.1.0.view", @"/Views/Query/Details.cshtml")]
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
#line 1 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60e5c5e1f15a02aca69da3c4f4e8dfb7060f61d1", @"/Views/Query/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e90093b101f83f068c3326cd49fefb5d4ecfa1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Query_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WaterBillAppCore.Models.Query>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>Query Details</h1>\r\n\r\n<div class=\"card mb-3\">\r\n    <div class=\"card-header\">\r\n        ");
#nullable restore
#line 16 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
   Write(Model.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <b>");
#nullable restore
#line 16 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
                          Write(Model.QueryStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 19 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
                          Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h5>\r\n        <p>\r\n            ");
#nullable restore
#line 21 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n\r\n        <p>\r\n            <span class=\"small\">  ");
#nullable restore
#line 25 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
                             Write(Html.DisplayNameFor(model => model.AccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>  <br>\r\n            ");
#nullable restore
#line 26 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
       Write(Model.AccountNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <hr>\r\n        </p>\r\n\r\n        <p>\r\n            <span class=\"small\">  ");
#nullable restore
#line 31 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
                             Write(Html.DisplayNameFor(model => model.CustomerAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>  <br>\r\n            ");
#nullable restore
#line 32 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
       Write(Model.CustomerAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 33 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
             if (!string.IsNullOrEmpty(Model.AddressUrl))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n                <a class=\"btn btn-link\" target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 1043, "\"", 1067, 1);
#nullable restore
#line 36 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
WriteAttributeValue("", 1050, Model.AddressUrl, 1050, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Directions</a>\r\n");
#nullable restore
#line 37 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <hr>\r\n        </p>\r\n\r\n\r\n        <p>\r\n            <span class=\"small\">  ");
#nullable restore
#line 44 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
                             Write(Html.DisplayNameFor(model => model.CustomerEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>  <br>\r\n            ");
#nullable restore
#line 45 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
       Write(Model.CustomerEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <hr>\r\n        </p>\r\n\r\n        <p>\r\n            <span class=\"small\">  ");
#nullable restore
#line 50 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
                             Write(Html.DisplayNameFor(model => model.CustomerPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>  <br>\r\n            ");
#nullable restore
#line 51 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
       Write(Model.CustomerPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <hr>\r\n        </p>\r\n\r\n        <p>\r\n            <span class=\"small\">  ");
#nullable restore
#line 56 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
                             Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>  <br>\r\n            ");
#nullable restore
#line 57 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
       Write(Model.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <hr>\r\n        </p>\r\n    </div>\r\n    <div class=\"card-footer\">\r\n\r\n\r\n");
#nullable restore
#line 64 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
         if (SignInManager.IsSignedIn(User))
        {
            if (User.IsInRole("Agent"))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
                 if (Model.QueryStatus == "New")
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60e5c5e1f15a02aca69da3c4f4e8dfb7060f61d110677", async() => {
                WriteLiteral("Accept");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
                                                   WriteLiteral(Model.QueryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 72 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
                 if (Model.QueryStatus == "Accepted")
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60e5c5e1f15a02aca69da3c4f4e8dfb7060f61d113453", async() => {
                WriteLiteral("Directions");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
                                                   WriteLiteral(Model.QueryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60e5c5e1f15a02aca69da3c4f4e8dfb7060f61d115747", async() => {
                WriteLiteral("In Progress");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
                                                   WriteLiteral(Model.QueryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 79 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
                 if (Model.QueryStatus == "In Progress")
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60e5c5e1f15a02aca69da3c4f4e8dfb7060f61d118531", async() => {
                WriteLiteral("Close Query");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
                                                   WriteLiteral(Model.QueryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 86 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\ndumiso.mthembu\source\repos\WaterBillAppCore\WaterBillAppCore\Views\Query\Details.cshtml"
                 
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WaterBillAppCore.Models.Query> Html { get; private set; }
    }
}
#pragma warning restore 1591
