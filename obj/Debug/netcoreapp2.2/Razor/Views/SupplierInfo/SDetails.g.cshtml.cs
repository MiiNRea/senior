#pragma checksum "c:\Users\MiiNRea\Desktop\sproject\Views\SupplierInfo\SDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df54a734bd1b0821cd72fcd9353557e53c490d6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SupplierInfo_SDetails), @"mvc.1.0.view", @"/Views/SupplierInfo/SDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SupplierInfo/SDetails.cshtml", typeof(AspNetCore.Views_SupplierInfo_SDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df54a734bd1b0821cd72fcd9353557e53c490d6f", @"/Views/SupplierInfo/SDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb6db91a464338634b626bcf055f7479d45db7f3", @"/Views/_ViewImports.cshtml")]
    public class Views_SupplierInfo_SDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sproject.Models.SupplierInfo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ProductInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(37, 156, true);
            WriteLiteral("\r\n<div>\r\n    <h4>Supplier Informations</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            Supplier name\r\n            <!-- ");
            EndContext();
            BeginContext(194, 49, false);
#line 9 "c:\Users\MiiNRea\Desktop\sproject\Views\SupplierInfo\SDetails.cshtml"
            Write(Html.DisplayNameFor(model => model.supplier_name));

#line default
#line hidden
            EndContext();
            BeginContext(243, 67, true);
            WriteLiteral(" -->\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(311, 45, false);
#line 12 "c:\Users\MiiNRea\Desktop\sproject\Views\SupplierInfo\SDetails.cshtml"
       Write(Html.DisplayFor(model => model.supplier_name));

#line default
#line hidden
            EndContext();
            BeginContext(356, 95, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Contact person\r\n            <!-- ");
            EndContext();
            BeginContext(452, 51, false);
#line 16 "c:\Users\MiiNRea\Desktop\sproject\Views\SupplierInfo\SDetails.cshtml"
            Write(Html.DisplayNameFor(model => model.supplier_person));

#line default
#line hidden
            EndContext();
            BeginContext(503, 67, true);
            WriteLiteral(" -->\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(571, 47, false);
#line 19 "c:\Users\MiiNRea\Desktop\sproject\Views\SupplierInfo\SDetails.cshtml"
       Write(Html.DisplayFor(model => model.supplier_person));

#line default
#line hidden
            EndContext();
            BeginContext(618, 93, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Phone number\r\n            <!-- ");
            EndContext();
            BeginContext(712, 50, false);
#line 23 "c:\Users\MiiNRea\Desktop\sproject\Views\SupplierInfo\SDetails.cshtml"
            Write(Html.DisplayNameFor(model => model.supplier_phone));

#line default
#line hidden
            EndContext();
            BeginContext(762, 67, true);
            WriteLiteral(" -->\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(830, 46, false);
#line 26 "c:\Users\MiiNRea\Desktop\sproject\Views\SupplierInfo\SDetails.cshtml"
       Write(Html.DisplayFor(model => model.supplier_phone));

#line default
#line hidden
            EndContext();
            BeginContext(876, 88, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Address\r\n            <!-- ");
            EndContext();
            BeginContext(965, 52, false);
#line 30 "c:\Users\MiiNRea\Desktop\sproject\Views\SupplierInfo\SDetails.cshtml"
            Write(Html.DisplayNameFor(model => model.supplier_address));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 67, true);
            WriteLiteral(" -->\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1085, 48, false);
#line 33 "c:\Users\MiiNRea\Desktop\sproject\Views\SupplierInfo\SDetails.cshtml"
       Write(Html.DisplayFor(model => model.supplier_address));

#line default
#line hidden
            EndContext();
            BeginContext(1133, 85, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Type\r\n            <!-- ");
            EndContext();
            BeginContext(1219, 49, false);
#line 37 "c:\Users\MiiNRea\Desktop\sproject\Views\SupplierInfo\SDetails.cshtml"
            Write(Html.DisplayNameFor(model => model.supplier_type));

#line default
#line hidden
            EndContext();
            BeginContext(1268, 67, true);
            WriteLiteral(" -->\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1336, 64, false);
#line 40 "c:\Users\MiiNRea\Desktop\sproject\Views\SupplierInfo\SDetails.cshtml"
       Write(Html.DisplayFor(model => model.supplier_type.supplier_type_name));

#line default
#line hidden
            EndContext();
            BeginContext(1400, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1447, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df54a734bd1b0821cd72fcd9353557e53c490d6f8339", async() => {
                BeginContext(1498, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            BeginContext(1514, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sproject.Models.SupplierInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
