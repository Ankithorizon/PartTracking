#pragma checksum "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c050c43e72ae5d2a52684633f5edac0788699b77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Warehouse_Index), @"mvc.1.0.view", @"/Views/Warehouse/Index.cshtml")]
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
#line 1 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\_ViewImports.cshtml"
using PartTracking.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\_ViewImports.cshtml"
using PartTracking.Mvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\_ViewImports.cshtml"
using PartTracking.Context.Models.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
using PartTracking.Context.Models.DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c050c43e72ae5d2a52684633f5edac0788699b77", @"/Views/Warehouse/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cc372da67165c24d690abe9b6dcf05489173a12", @"/Views/_ViewImports.cshtml")]
    public class Views_Warehouse_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PartTracking.Context.Models.DTO.WarehouseOrderView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderPart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
  
    ViewData["Title"] = "Warehouse - Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .header {
        justify-content: center;
        align-items: center;
        border: 5px solid red;
        padding-top: 5px;
        padding-bottom: 5px;
        padding-left: 5px;
        font-size: x-large;
        text-align: center;
    }

    .tableData {
        font-size: x-large;
    }
</style>

<div class=""row"">
    <div class=""col-sm-3"">
    </div>
    <div class=""col-sm-6 header"">
        Warehouse - Part Management
    </div>
    <div class=""col-sm-3"">
    </div>
</div>

<p></p>
");
#nullable restore
#line 36 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
 if (TempData["RefCode"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container response\">\r\n        <h3>Order Confirmation Code : ");
#nullable restore
#line 39 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
                                 Write(TempData["RefCode"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n");
#nullable restore
#line 41 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p></p>\r\n\r\n<p></p>\r\n");
#nullable restore
#line 45 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
 if (TempData["Exception"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container response\">\r\n        <h3>Error : ");
#nullable restore
#line 48 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
               Write(TempData["Exception"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n");
#nullable restore
#line 50 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p></p>\r\n\r\n<p></p>\r\n");
#nullable restore
#line 54 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
 if (TempData["SPResponse"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container response\">\r\n        <h3>");
#nullable restore
#line 57 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
       Write(TempData["SPResponse"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n");
#nullable restore
#line 59 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p></p>\r\n\r\n<p class=\"tableData\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c050c43e72ae5d2a52684633f5edac0788699b777442", async() => {
                WriteLiteral("Order Part!");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n<p></p>\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-1\">\r\n        </div>\r\n        <div class=\"col-sm-6\" style=\"font-size:x-large; font-display:block;\">\r\n            <!-- search by part -->\r\n            <p>\r\n");
#nullable restore
#line 74 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
                 using (@Html.BeginForm("Index", "Warehouse", FormMethod.Get))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
               Write(Html.TextBox("SearchString"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input style=\"margin-top:-10px;\"\r\n                           type=\"submit\"\r\n                           class=\"btn btn-primary\"\r\n                           value=\"Search Part\" />\r\n");
#nullable restore
#line 81 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </p>\r\n            <hr />\r\n            <p></p>\r\n        </div>\r\n    </div>\r\n</div>\r\n<p></p>\r\n\r\n");
#nullable restore
#line 90 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    Order#\r\n                </th>\r\n                <th>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c050c43e72ae5d2a52684633f5edac0788699b7710402", async() => {
#nullable restore
#line 99 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
                                                                                         Write(Html.DisplayNameFor(model => model.PartName));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 99 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
                                                   WriteLiteral(ViewData["PartNameSortParm"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 102 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.OrderQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c050c43e72ae5d2a52684633f5edac0788699b7713312", async() => {
#nullable restore
#line 105 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
                                                                                     Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 105 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
                                                   WriteLiteral(ViewData["DateSortParm"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c050c43e72ae5d2a52684633f5edac0788699b7715868", async() => {
#nullable restore
#line 108 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
                                                                                            Write(Html.DisplayNameFor(model => model.OrderStatus));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
                                                   WriteLiteral(ViewData["OrderStatusSortParm"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Ref-Code#\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 117 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 121 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderMasterId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 124 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PartCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br />\r\n                    [");
#nullable restore
#line 126 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
                Write(Html.DisplayFor(modelItem => item.PartName));

#line default
#line hidden
#nullable disable
            WriteLiteral("]\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 129 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 132 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 134 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
                  
                    string orderStatus = "";
                    int value = (int)item.OrderStatus;
                    if (Enum.IsDefined(typeof(OrderStatusType), value))
                        orderStatus = ((OrderStatusType)value).ToString();
                    else
                        orderStatus = "N/A";

                    if (value == 0)
                    {
                        // Confirmed

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"color:green;font-size:large;\">\r\n                            ");
#nullable restore
#line 146 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
                       Write(orderStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 148 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
                    }
                    else if (value == 1)
                    {
                        // Received

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"color:red; font-size:large;\">\r\n                            ");
#nullable restore
#line 153 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
                       Write(orderStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 155 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
                    }
                    else
                    {
                        // Half_Received

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"color:blue; font-size:large;\">\r\n                            ");
#nullable restore
#line 160 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
                       Write(orderStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 162 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 165 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.RefCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 168 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
               Write(Html.ActionLink("Edit", "OrderEdit", new { id = item.OrderMasterId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 169 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
               Write(Html.ActionLink("Details", "OrderDetails", new { id = item.OrderMasterId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 172 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 175 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p></p>\r\n    <div class=\"container\" style=\"color:red; font-size:xx-large;\">\r\n        Part NOT Found!\r\n    </div>\r\n    <p></p>\r\n");
#nullable restore
#line 183 "C:\Users\ankit_2\source\repos\PartTracking\PartTracking.Mvc\Views\Warehouse\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"">

        // disappear after 3 seconds,,,
        setTimeout(function () { $('.response').fadeOut(); }, 3000);

        function DisableBackButton() {
            window.history.forward()
        }
        DisableBackButton();
        window.onload = DisableBackButton;
        window.onpageshow = function (evt) { if (evt.persisted) DisableBackButton() }
        window.onunload = function () { void (0) }

    </script>

");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PartTracking.Context.Models.DTO.WarehouseOrderView>> Html { get; private set; }
    }
}
#pragma warning restore 1591