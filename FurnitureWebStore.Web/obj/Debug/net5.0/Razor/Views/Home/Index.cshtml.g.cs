#pragma checksum "D:\master-Anul2-sem1\afaceri-electronice\proiect\proiect-afaceri-electronice\FurnitureWebStore.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57f2366246933dbdeca0f10ded77d5e5a9c6ef00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\master-Anul2-sem1\afaceri-electronice\proiect\proiect-afaceri-electronice\FurnitureWebStore.Web\Views\_ViewImports.cshtml"
using FurnitureWebStore.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\master-Anul2-sem1\afaceri-electronice\proiect\proiect-afaceri-electronice\FurnitureWebStore.Web\Views\_ViewImports.cshtml"
using FurnitureWebStore.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\master-Anul2-sem1\afaceri-electronice\proiect\proiect-afaceri-electronice\FurnitureWebStore.Web\Views\_ViewImports.cshtml"
using FurnitureWebStore.Models.DTOs.VM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\master-Anul2-sem1\afaceri-electronice\proiect\proiect-afaceri-electronice\FurnitureWebStore.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57f2366246933dbdeca0f10ded77d5e5a9c6ef00", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad916e868c952bf7539f848882717fd3736036b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("no image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\master-Anul2-sem1\afaceri-electronice\proiect\proiect-afaceri-electronice\FurnitureWebStore.Web\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home Page";
    var detailsRoute = "/Details/{0}";
    var feedbackRoute = "/Feedback/{0}";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n\r\n");
#nullable restore
#line 9 "D:\master-Anul2-sem1\afaceri-electronice\proiect\proiect-afaceri-electronice\FurnitureWebStore.Web\Views\Home\Index.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-4\">\r\n    <div class=\"card mb-4\">\r\n\r\n        <div class=\"card-header\">\r\n            <h4 class=\"my-0 font-weight-normal\">\r\n                <label style=\"font-size: 23px; color: #ff1a75; \">");
#nullable restore
#line 16 "D:\master-Anul2-sem1\afaceri-electronice\proiect\proiect-afaceri-electronice\FurnitureWebStore.Web\Views\Home\Index.cshtml"
                                                            Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </h4>\r\n        </div>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "57f2366246933dbdeca0f10ded77d5e5a9c6ef006057", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 541, "~/", 541, 2, true);
#nullable restore
#line 20 "D:\master-Anul2-sem1\afaceri-electronice\proiect\proiect-afaceri-electronice\FurnitureWebStore.Web\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 543, product.ImagePath, 543, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        <div class=\"card-body\">\r\n            <div class=\"d-flex justify-content-between align-items-center\">\r\n                <div class=\"btn-group\">\r\n                    <label style=\"font-size: 20px; color: #cd1818\"><b>$");
#nullable restore
#line 25 "D:\master-Anul2-sem1\afaceri-electronice\proiect\proiect-afaceri-electronice\FurnitureWebStore.Web\Views\Home\Index.cshtml"
                                                                  Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></label>\r\n                </div>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 876, "\"", 923, 1);
#nullable restore
#line 27 "D:\master-Anul2-sem1\afaceri-electronice\proiect\proiect-afaceri-electronice\FurnitureWebStore.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 883, string.Format(detailsRoute, product.Id), 883, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn pull-right btn-outline-info\">View Details</a>\r\n                <br/>\r\n                <br />\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1048, "\"", 1096, 1);
#nullable restore
#line 30 "D:\master-Anul2-sem1\afaceri-electronice\proiect\proiect-afaceri-electronice\FurnitureWebStore.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1055, string.Format(feedbackRoute, product.Id), 1055, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn fa-pull-left btn-outline-info\">View Feedback</a>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>");
#nullable restore
#line 35 "D:\master-Anul2-sem1\afaceri-electronice\proiect\proiect-afaceri-electronice\FurnitureWebStore.Web\Views\Home\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
