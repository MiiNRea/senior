#pragma checksum "c:\Users\MiiNRea\Desktop\sproject1\Views\ProductInfo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "983ee2b0162291a760305e2bcf9818e4d0f2970d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductInfo_Index), @"mvc.1.0.view", @"/Views/ProductInfo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProductInfo/Index.cshtml", typeof(AspNetCore.Views_ProductInfo_Index))]
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
#line 1 "c:\Users\MiiNRea\Desktop\sproject1\Views\_ViewImports.cshtml"
using sproject;

#line default
#line hidden
#line 2 "c:\Users\MiiNRea\Desktop\sproject1\Views\_ViewImports.cshtml"
using sproject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"983ee2b0162291a760305e2bcf9818e4d0f2970d", @"/Views/ProductInfo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb6db91a464338634b626bcf055f7479d45db7f3", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductInfo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<sproject.Models.ProductInfo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SupplierInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(48, 8, true);
            WriteLiteral("<p>\n    ");
            EndContext();
            BeginContext(56, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "983ee2b0162291a760305e2bcf9818e4d0f2970d4707", async() => {
                BeginContext(79, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(93, 182, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                Product ID\n            </th>\n            <th>\n                Product name\n                <!-- ");
            EndContext();
            BeginContext(276, 48, false);
#line 13 "c:\Users\MiiNRea\Desktop\sproject1\Views\ProductInfo\Index.cshtml"
                Write(Html.DisplayNameFor(model => model.product_name));

#line default
#line hidden
            EndContext();
            BeginContext(324, 84, true);
            WriteLiteral(" -->\n            </th>\n            <th>\n                Series\n                <!-- ");
            EndContext();
            BeginContext(409, 50, false);
#line 17 "c:\Users\MiiNRea\Desktop\sproject1\Views\ProductInfo\Index.cshtml"
                Write(Html.DisplayNameFor(model => model.product_series));

#line default
#line hidden
            EndContext();
            BeginContext(459, 82, true);
            WriteLiteral(" -->\n            </th>\n            <th>\n                Size\n                <!-- ");
            EndContext();
            BeginContext(542, 48, false);
#line 21 "c:\Users\MiiNRea\Desktop\sproject1\Views\ProductInfo\Index.cshtml"
                Write(Html.DisplayNameFor(model => model.product_size));

#line default
#line hidden
            EndContext();
            BeginContext(590, 91, true);
            WriteLiteral(" -->\n            </th>\n            <th>\n                Supplier name\n                <!-- ");
            EndContext();
            BeginContext(682, 48, false);
#line 25 "c:\Users\MiiNRea\Desktop\sproject1\Views\ProductInfo\Index.cshtml"
                Write(Html.DisplayNameFor(model => model.supplierInfo));

#line default
#line hidden
            EndContext();
            BeginContext(730, 84, true);
            WriteLiteral(" -->\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 31 "c:\Users\MiiNRea\Desktop\sproject1\Views\ProductInfo\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(845, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(892, 45, false);
#line 34 "c:\Users\MiiNRea\Desktop\sproject1\Views\ProductInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.product_id));

#line default
#line hidden
            EndContext();
            BeginContext(937, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(990, 47, false);
#line 37 "c:\Users\MiiNRea\Desktop\sproject1\Views\ProductInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.product_name));

#line default
#line hidden
            EndContext();
            BeginContext(1037, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1090, 49, false);
#line 40 "c:\Users\MiiNRea\Desktop\sproject1\Views\ProductInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.product_series));

#line default
#line hidden
            EndContext();
            BeginContext(1139, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1192, 47, false);
#line 43 "c:\Users\MiiNRea\Desktop\sproject1\Views\ProductInfo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.product_size));

#line default
#line hidden
            EndContext();
            BeginContext(1239, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1291, 192, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "983ee2b0162291a760305e2bcf9818e4d0f2970d9947", async() => {
                BeginContext(1379, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
                BeginContext(1401, 61, false);
#line 47 "c:\Users\MiiNRea\Desktop\sproject1\Views\ProductInfo\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.supplierInfo.supplier_name));

#line default
#line hidden
                EndContext();
                BeginContext(1462, 17, true);
                WriteLiteral("\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "c:\Users\MiiNRea\Desktop\sproject1\Views\ProductInfo\Index.cshtml"
                                                                         WriteLiteral(item.supplier_id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1483, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1535, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "983ee2b0162291a760305e2bcf9818e4d0f2970d12984", async() => {
                BeginContext(1588, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "c:\Users\MiiNRea\Desktop\sproject1\Views\ProductInfo\Index.cshtml"
                                       WriteLiteral(item.product_id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1596, 62, true);
            WriteLiteral(" |\n                <!-- <a asp-action=\"Details\" asp-route-id=\"");
            EndContext();
            BeginContext(1659, 15, false);
#line 52 "c:\Users\MiiNRea\Desktop\sproject1\Views\ProductInfo\Index.cshtml"
                                                      Write(item.product_id);

#line default
#line hidden
            EndContext();
            BeginContext(1674, 36, true);
            WriteLiteral("\">Details</a> | -->\n                ");
            EndContext();
            BeginContext(1710, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "983ee2b0162291a760305e2bcf9818e4d0f2970d15766", async() => {
                BeginContext(1765, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "c:\Users\MiiNRea\Desktop\sproject1\Views\ProductInfo\Index.cshtml"
                                         WriteLiteral(item.product_id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1775, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 56 "c:\Users\MiiNRea\Desktop\sproject1\Views\ProductInfo\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1810, 23, true);
            WriteLiteral("    </tbody>\n</table>\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<sproject.Models.ProductInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
