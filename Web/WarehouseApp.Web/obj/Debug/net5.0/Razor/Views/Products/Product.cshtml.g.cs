#pragma checksum "C:\Users\plame\Desktop\WarehouseApp.NET\Web\WarehouseApp.Web\Views\Products\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61da18478ddf6b259dc0d4e67a6bd1588c3c1fe9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Product), @"mvc.1.0.view", @"/Views/Products/Product.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61da18478ddf6b259dc0d4e67a6bd1588c3c1fe9", @"/Views/Products/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80bec2deaa932e96476fad10a61bea4e2dc6f677", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WarehouseApp.Web.ViewModels.Product.ProductDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"single-recipe-layout1\">\n    <h1 class=\"item-title\">");
#nullable restore
#line 3 "C:\Users\plame\Desktop\WarehouseApp.NET\Web\WarehouseApp.Web\Views\Products\Product.cshtml"
                      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    <div >\n        \n                    \n                     Added on: ");
#nullable restore
#line 7 "C:\Users\plame\Desktop\WarehouseApp.NET\Web\WarehouseApp.Web\Views\Products\Product.cshtml"
                          Write(Model.CreatedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    \n          \n    </div>\n    \n    \n    \n    \n    <div class=\"making-elements-wrap\">\n        <div class=\"row\">\n            <div class=\"col-md-6\">\n                <div>\n                    <img class=\"product-img\"");
            BeginWriteAttribute("src", " src=\"", 465, "\"", 486, 1);
#nullable restore
#line 19 "C:\Users\plame\Desktop\WarehouseApp.NET\Web\WarehouseApp.Web\Views\Products\Product.cshtml"
WriteAttributeValue("", 471, Model.ImageUrl, 471, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Product"">
                </div>
            </div>
            <div class=""col-xl-6 col-6"">
                <div class=""product-description"">
                    <h3 class=""item-title"">Product Details</h3>
                    <p>Description:</p>
                    <p class=""item-description"">
                       <b> ");
#nullable restore
#line 27 "C:\Users\plame\Desktop\WarehouseApp.NET\Web\WarehouseApp.Web\Views\Products\Product.cshtml"
                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\n                    </p>\n                    <p>Price: <b>");
#nullable restore
#line 29 "C:\Users\plame\Desktop\WarehouseApp.NET\Web\WarehouseApp.Web\Views\Products\Product.cshtml"
                            Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\n                    <p>Total Quantity: <b>");
#nullable restore
#line 30 "C:\Users\plame\Desktop\WarehouseApp.NET\Web\WarehouseApp.Web\Views\Products\Product.cshtml"
                                     Write(Model.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\n                    <p>Available in cupboards:</p>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WarehouseApp.Web.ViewModels.Product.ProductDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
