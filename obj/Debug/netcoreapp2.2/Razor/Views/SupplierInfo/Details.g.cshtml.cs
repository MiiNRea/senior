#pragma checksum "c:\Users\MiiNRea\Desktop\sproject1\Views\SupplierInfo\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d3a32d5ee88d7a678692d14d1b86e0cb4dd6d6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SupplierInfo_Details), @"mvc.1.0.view", @"/Views/SupplierInfo/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SupplierInfo/Details.cshtml", typeof(AspNetCore.Views_SupplierInfo_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d3a32d5ee88d7a678692d14d1b86e0cb4dd6d6b", @"/Views/SupplierInfo/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb6db91a464338634b626bcf055f7479d45db7f3", @"/Views/_ViewImports.cshtml")]
    public class Views_SupplierInfo_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sproject.Models.SupplierInfo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(36, 140, true);
            WriteLiteral("\n<div>\n    <h4>SupplierInfo</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            Supplier name\n            <!-- ");
            EndContext();
            BeginContext(177, 49, false);
#line 9 "c:\Users\MiiNRea\Desktop\sproject1\Views\SupplierInfo\Details.cshtml"
            Write(Html.DisplayNameFor(model => model.supplier_name));

#line default
#line hidden
            EndContext();
            BeginContext(226, 45, true);
            WriteLiteral(" -->\n\n        </dt>\n    \n\n   <input id=\"sup1\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 271, "\"", 297, 1);
#line 14 "c:\Users\MiiNRea\Desktop\sproject1\Views\SupplierInfo\Details.cshtml"
WriteAttributeValue("", 279, Model.supplier_id, 279, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(298, 63, true);
            WriteLiteral(" hidden/></input>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(362, 45, false);
#line 16 "c:\Users\MiiNRea\Desktop\sproject1\Views\SupplierInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.supplier_name));

#line default
#line hidden
            EndContext();
            BeginContext(407, 91, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            Contact person\n            <!-- ");
            EndContext();
            BeginContext(499, 51, false);
#line 20 "c:\Users\MiiNRea\Desktop\sproject1\Views\SupplierInfo\Details.cshtml"
            Write(Html.DisplayNameFor(model => model.supplier_person));

#line default
#line hidden
            EndContext();
            BeginContext(550, 64, true);
            WriteLiteral(" -->\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(615, 47, false);
#line 23 "c:\Users\MiiNRea\Desktop\sproject1\Views\SupplierInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.supplier_person));

#line default
#line hidden
            EndContext();
            BeginContext(662, 89, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            Phone number\n            <!-- ");
            EndContext();
            BeginContext(752, 50, false);
#line 27 "c:\Users\MiiNRea\Desktop\sproject1\Views\SupplierInfo\Details.cshtml"
            Write(Html.DisplayNameFor(model => model.supplier_phone));

#line default
#line hidden
            EndContext();
            BeginContext(802, 64, true);
            WriteLiteral(" -->\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(867, 46, false);
#line 30 "c:\Users\MiiNRea\Desktop\sproject1\Views\SupplierInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.supplier_phone));

#line default
#line hidden
            EndContext();
            BeginContext(913, 84, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            Address\n            <!-- ");
            EndContext();
            BeginContext(998, 52, false);
#line 34 "c:\Users\MiiNRea\Desktop\sproject1\Views\SupplierInfo\Details.cshtml"
            Write(Html.DisplayNameFor(model => model.supplier_address));

#line default
#line hidden
            EndContext();
            BeginContext(1050, 64, true);
            WriteLiteral(" -->\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1115, 48, false);
#line 37 "c:\Users\MiiNRea\Desktop\sproject1\Views\SupplierInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.supplier_address));

#line default
#line hidden
            EndContext();
            BeginContext(1163, 81, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            Type\n            <!-- ");
            EndContext();
            BeginContext(1245, 49, false);
#line 41 "c:\Users\MiiNRea\Desktop\sproject1\Views\SupplierInfo\Details.cshtml"
            Write(Html.DisplayNameFor(model => model.supplier_type));

#line default
#line hidden
            EndContext();
            BeginContext(1294, 64, true);
            WriteLiteral(" -->\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1359, 64, false);
#line 44 "c:\Users\MiiNRea\Desktop\sproject1\Views\SupplierInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.supplier_type.supplier_type_name));

#line default
#line hidden
            EndContext();
            BeginContext(1423, 193, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n<table class=\"table\" id=\"table1\">\n    <tr>\n        <th>Product sell</th>\n        <th>Series</th>\n        <th>Size</th>\n    </tr>\n</table>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1616, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d3a32d5ee88d7a678692d14d1b86e0cb4dd6d6b8831", async() => {
                BeginContext(1671, 4, true);
                WriteLiteral("Edit");
                EndContext();
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
#line 58 "c:\Users\MiiNRea\Desktop\sproject1\Views\SupplierInfo\Details.cshtml"
                           WriteLiteral(Model.supplier_id);

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
            BeginContext(1679, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1686, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d3a32d5ee88d7a678692d14d1b86e0cb4dd6d6b11148", async() => {
                BeginContext(1708, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1724, 10, true);
            WriteLiteral("\n</div>\n\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1751, 1414, true);
                WriteLiteral(@"
    <script>
        var list = [];
        var tbl = $('#table1');
        $(document).ready(tb);

        function tb(){
            $.get(""/productinfo/products"", product_data_arrived);
        }

        function product_data_arrived (data){
            console.log(""product table"",data);
            list = data;
            var supplier_id = $('#sup1').val();
            var found = list.filter(function(x){
                return x.supplier_id == supplier_id;
            });
           console.log(found);
            /*-- var product_id = found.product_id;
            var product_name = found.product_name;
            var product_series = found.product_series;
            var product_size = found.product_size;

            var row = {
                product_id : found.product_id,
                product_name : found.product_name,
                product_series : found.product_series,
                product_size : found.product_size,
            }; --*/

        table(found);
        }
        function ");
                WriteLiteral(@"table(list){
            for (var i = 0; i < list.length; i++) {
            var row = tr(td(list[i].product_name) + td(list[i].product_series)+ td(list[i].product_size));
            tbl.append(row);
            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sproject.Models.SupplierInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
