#pragma checksum "C:\Users\plame\Desktop\WarehouseApp.NET\Web\WarehouseApp.Web\Views\Products\Cupboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2996fcb822baf7a89af196f03bef3192a97982d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Cupboard), @"mvc.1.0.view", @"/Views/Products/Cupboard.cshtml")]
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
#line 1 "C:\Users\plame\Desktop\WarehouseApp.NET\Web\WarehouseApp.Web\Views\_ViewImports.cshtml"
using WarehouseApp.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\plame\Desktop\WarehouseApp.NET\Web\WarehouseApp.Web\Views\_ViewImports.cshtml"
using WarehouseApp.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2996fcb822baf7a89af196f03bef3192a97982d9", @"/Views/Products/Cupboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80bec2deaa932e96476fad10a61bea4e2dc6f677", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Cupboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WarehouseApp.Web.ViewModels.Product.ProductsInCupboardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\plame\Desktop\WarehouseApp.NET\Web\WarehouseApp.Web\Views\Products\Cupboard.cshtml"
  
    this.ViewData["Title"] = "Cupboard contents";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 7 "C:\Users\plame\Desktop\WarehouseApp.NET\Web\WarehouseApp.Web\Views\Products\Cupboard.cshtml"
Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<hr />\n<div class=\"row\">\n");
#nullable restore
#line 10 "C:\Users\plame\Desktop\WarehouseApp.NET\Web\WarehouseApp.Web\Views\Products\Cupboard.cshtml"
     foreach (var product in this.Model.Products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card col-md-3\" style=\"width: 18rem;\">\n            <div class=\"image-container\">\n                <img");
            BeginWriteAttribute("src", " src=\"", 362, "\"", 385, 1);
#nullable restore
#line 14 "C:\Users\plame\Desktop\WarehouseApp.NET\Web\WarehouseApp.Web\Views\Products\Cupboard.cshtml"
WriteAttributeValue("", 368, product.ImageUrl, 368, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\n            </div>\n\n            <div class=\"card-body\">\n                <h5 class=\"card-title\">");
#nullable restore
#line 18 "C:\Users\plame\Desktop\WarehouseApp.NET\Web\WarehouseApp.Web\Views\Products\Cupboard.cshtml"
                                  Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                <p class=\"card-text\">Quantity in cupboard: ");
#nullable restore
#line 19 "C:\Users\plame\Desktop\WarehouseApp.NET\Web\WarehouseApp.Web\Views\Products\Cupboard.cshtml"
                                                      Write(product.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2996fcb822baf7a89af196f03bef3192a97982d95881", async() => {
                WriteLiteral("Details");
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
#line 20 "C:\Users\plame\Desktop\WarehouseApp.NET\Web\WarehouseApp.Web\Views\Products\Cupboard.cshtml"
                                          WriteLiteral(product.Id);

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
            WriteLiteral("\n\n            </div>\n        </div>\n");
#nullable restore
#line 24 "C:\Users\plame\Desktop\WarehouseApp.NET\Web\WarehouseApp.Web\Views\Products\Cupboard.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WarehouseApp.Web.ViewModels.Product.ProductsInCupboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
