#pragma checksum "C:\Users\TOAN\Documents\Srouce\watchShop-project\aspcore-watchshop\Views\Shared\_PartialHeader.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0be207cc5445980d618f4e7de6dec29ddda4187"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialHeader), @"mvc.1.0.view", @"/Views/Shared/_PartialHeader.cshtml")]
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
#line 1 "C:\Users\TOAN\Documents\Srouce\watchShop-project\aspcore-watchshop\Views\_ViewImports.cshtml"
using aspcore_watchshop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TOAN\Documents\Srouce\watchShop-project\aspcore-watchshop\Views\_ViewImports.cshtml"
using aspcore_watchshop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0be207cc5445980d618f4e7de6dec29ddda4187", @"/Views/Shared/_PartialHeader.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcc9903d68fd33c13bb283de0d0301e562f01f82", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialHeader : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/tim-kiem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<header class=""container-fluid"">
    <div class=""row align-items-center"">
        <!--Nav Mobile-->
        <div class=""col-3 d-lg-none"">
            <a id=""menu"" class=""nav-item"" href=""#!"" title=""Hamberger Icon""><i class=""icon las la-bars""></i></a>
        </div>
        <!--Title-->
        <div class=""col-6 col-lg-2 text-center text-lg-left"">
            <h1 class=""py-3 text-3""><a href=""/"" title=""Trang chủ"">");
#nullable restore
#line 9 "C:\Users\TOAN\Documents\Srouce\watchShop-project\aspcore-watchshop\Views\Shared\_PartialHeader.cshtml"
                                                             Write(LayoutData.Instance.NameStore);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h1>
        </div>
        <!--Nav Desktop-->
        <div class=""col-6 d-none col-lg-8 d-lg-block"">
            <nav class=""nav-container"">
                <a class=""nav-item anim-center"" href=""/khuyen-mai"" title=""Khuyến mãi"">khuyến mãi</a>
                <a class=""nav-item anim-center"" href=""/dong-ho-nam"" title=""Đồng hồ nam"">nam</a>
                <a class=""nav-item anim-center"" href=""/dong-ho-nu"" title=""Đồng hồ nữ"">nữ</a>
                <a class=""nav-item anim-center"" href=""/dong-ho-doi"" title=""Đồng hồ đôi"">cặp đôi</a>
                <a class=""nav-item anim-center"" href=""/phu-kien"" title=""Phụ kiện"">phụ kiện</a>
            </nav>
        </div>
        <!--Nav Icon-->
        <div class=""col-3 col-lg-2 d-lg-block"">
            <div class=""d-flex justify-content-end"">
                <a class=""nav-item anim-center nav-icon d-none d-lg-block"" title=""Search Icon"">
                    <i id=""search"" class=""icon las la-search""></i>
                </a>
                <a class=""nav-i");
            WriteLiteral(@"tem anim-center nav-icon"" href=""/gio-hang"" title=""Cart Icon"">
                    <div class=""cart-shopping"">
                        <i class=""icon las la-shopping-cart""></i>
                        <span id=""cart-items"" class=""white bg-red""></span>
                    </div>
                </a>
            </div>
        </div>
    </div>
    <!--Side Menu mobile-->
    <div class=""nav-mobile d-lg-none"">
        <nav class=""nav-container flex-column bg-white"">
            <a class=""nav-item-sm"" href=""/"" title=""Trang chủ"">trang chủ</a>
            <a id=""search-sm"" class=""nav-item-sm"" href=""#!"" title=""Tìm kiếm"">tìm kiếm</a>
            <a class=""nav-item-sm"" href=""/khuyen-mai"" title=""Khuyến mãi"">khuyến mãi</a>
            <a class=""nav-item-sm"" href=""/dong-ho-nam"" title=""Đồng hồ nam"">nam</a>
            <a class=""nav-item-sm"" href=""/dong-ho-nu"" title=""Đồng hồ nữ"">nữ</a>
            <a class=""nav-item-sm"" href=""/dong-ho-doi"" title=""Đồng hồ đôi"">cặp đôi</a>
            <a class=""nav-item-sm""");
            WriteLiteral(@" href=""/phu-kien"" title=""Phụ kiện"">phụ kiện</a>
            <a class=""nav-item-sm"" href=""/don-hang/kiem-tra"" title=""Kiểm trạng thái đơn hàng"">Kiểm trạng thái đơn
                hàng</a>
            <i class=""btn-classic red big-icon icon las la-times""></i>
        </nav>
        <span class=""overlay bg-black""></span>
    </div>
    <!--Search Bar-->
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0be207cc5445980d618f4e7de6dec29ddda41877315", async() => {
                WriteLiteral(@"
        <div class=""searchbar d-block bg-white"">
            <div class=""search-input"">
                <input type=""text"" name=""text"" placeholder=""Tìm kiếm sản phẩm ..."">
                <i class=""btn-classic red big-icon las la-times""></i>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
