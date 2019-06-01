#pragma checksum "c:\Users\MiiNRea\Desktop\sproject\Views\PurchaseOrder\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "617af2b4e89b52a509cdc8a7ea24b23baf050515"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PurchaseOrder_Details), @"mvc.1.0.view", @"/Views/PurchaseOrder/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PurchaseOrder/Details.cshtml", typeof(AspNetCore.Views_PurchaseOrder_Details))]
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
#line 1 "c:\Users\MiiNRea\Desktop\sproject\Views\_ViewImports.cshtml"
using sproject;

#line default
#line hidden
#line 2 "c:\Users\MiiNRea\Desktop\sproject\Views\_ViewImports.cshtml"
using sproject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"617af2b4e89b52a509cdc8a7ea24b23baf050515", @"/Views/PurchaseOrder/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb6db91a464338634b626bcf055f7479d45db7f3", @"/Views/_ViewImports.cshtml")]
    public class Views_PurchaseOrder_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sproject.Models.PurchaseDetailView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 105, true);
            WriteLiteral("<div>\r\n    <h4>Purchase Order Details</h4>\r\n    <hr />\r\n    </div>\r\n    <div>\r\n        <h5>Purchase ID : ");
            EndContext();
            BeginContext(149, 17, false);
#line 7 "c:\Users\MiiNRea\Desktop\sproject\Views\PurchaseOrder\Details.cshtml"
                     Write(Model.purchase_id);

#line default
#line hidden
            EndContext();
            BeginContext(166, 120, true);
            WriteLiteral("</h5>\r\n    </div>\r\n\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            Purchase date\r\n            <!-- ");
            EndContext();
            BeginContext(287, 49, false);
#line 13 "c:\Users\MiiNRea\Desktop\sproject\Views\PurchaseOrder\Details.cshtml"
            Write(Html.DisplayNameFor(model => model.purchase_date));

#line default
#line hidden
            EndContext();
            BeginContext(336, 67, true);
            WriteLiteral(" -->\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(404, 45, false);
#line 16 "c:\Users\MiiNRea\Desktop\sproject\Views\PurchaseOrder\Details.cshtml"
       Write(Html.DisplayFor(model => model.purchase_date));

#line default
#line hidden
            EndContext();
            BeginContext(449, 416, true);
            WriteLiteral(@"
        </dd>
    </dl>

<hr>

<table class=""table"" id = ""tb1"">
    <tr>
        <th>
            Product name
        </th>
        <th>
            Supplier name
        </th>
        <th>
            Quality
        </th>
        <th>
            Cost
        </th>
        <th>
            Selling price
        </th>
        <th>
            Status
        </th>
        
    </tr>
");
            EndContext();
#line 44 "c:\Users\MiiNRea\Desktop\sproject\Views\PurchaseOrder\Details.cshtml"
     foreach (var item in @Model.purchaseItems)
    {

#line default
#line hidden
            BeginContext(921, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(970, 17, false);
#line 48 "c:\Users\MiiNRea\Desktop\sproject\Views\PurchaseOrder\Details.cshtml"
           Write(item.product_name);

#line default
#line hidden
            EndContext();
            BeginContext(987, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1043, 18, false);
#line 51 "c:\Users\MiiNRea\Desktop\sproject\Views\PurchaseOrder\Details.cshtml"
           Write(item.supplier_name);

#line default
#line hidden
            EndContext();
            BeginContext(1061, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1117, 16, false);
#line 54 "c:\Users\MiiNRea\Desktop\sproject\Views\PurchaseOrder\Details.cshtml"
           Write(item.product_qty);

#line default
#line hidden
            EndContext();
            BeginContext(1133, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1189, 10, false);
#line 57 "c:\Users\MiiNRea\Desktop\sproject\Views\PurchaseOrder\Details.cshtml"
           Write(item.total);

#line default
#line hidden
            EndContext();
            BeginContext(1199, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1255, 18, false);
#line 60 "c:\Users\MiiNRea\Desktop\sproject\Views\PurchaseOrder\Details.cshtml"
           Write(item.selling_price);

#line default
#line hidden
            EndContext();
            BeginContext(1273, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1329, 11, false);
#line 63 "c:\Users\MiiNRea\Desktop\sproject\Views\PurchaseOrder\Details.cshtml"
           Write(item.status);

#line default
#line hidden
            EndContext();
            BeginContext(1340, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 66 "c:\Users\MiiNRea\Desktop\sproject\Views\PurchaseOrder\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(1383, 63, true);
            WriteLiteral("</table>\r\n\r\n<div>\r\n    <!-- <a asp-action=\"Edit\" asp-route-id=\"");
            EndContext();
            BeginContext(1447, 17, false);
#line 70 "c:\Users\MiiNRea\Desktop\sproject\Views\PurchaseOrder\Details.cshtml"
                                       Write(Model.purchase_id);

#line default
#line hidden
            EndContext();
            BeginContext(1464, 22, true);
            WriteLiteral("\">Edit</a> | -->\r\n    ");
            EndContext();
            BeginContext(1486, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "617af2b4e89b52a509cdc8a7ea24b23baf0505158533", async() => {
                BeginContext(1508, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(1524, 20, true);
            WriteLiteral("\r\n    \r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1561, 1388, true);
                WriteLiteral(@"
    <script>
        var list = [];
        var tab = $('#tb1')
        
        $(document).ready(cv);

        function cv(){
            /*-- $.get(""/purchaseitem/purchaseitems"", pd); --*/
            $.get(""/productinfo/products"", pr);
        }

        function pd(data){
            list = data;
            var found = list.filter(function(x){
                return x.purchase_id == purchase_id;
                table(found);
            });
            console.log(product_id);
            console.log(""found"",found);
            table(found);
        }

        function pr(data){
            list = data;
            var product_id = $('#pid').val();
            var found = list.filter(function(x){
                return x.product_id == product_id;
                table(found);
            });
            console.log(product_id);
            console.log(""found"",found);
            table(found);
        }

        function table(found){
            for (var i = 0; i < f");
                WriteLiteral(@"ound.length; i++) {
            var row = tr(td(found[i].product_name) + td(found[i].product_series)+ td(found[i].product_size));
            }
            tab.append(row);
        }

        function tr(data) {
         return '<tr>' + data + '</tr>';
     }

     function td(data) {
         return '<td>' + data + '</td>';
     }

    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sproject.Models.PurchaseDetailView> Html { get; private set; }
    }
}
#pragma warning restore 1591
