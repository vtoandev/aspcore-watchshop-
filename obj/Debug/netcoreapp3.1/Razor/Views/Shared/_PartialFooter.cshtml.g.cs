#pragma checksum "C:\Users\TOAN\Srouce\aspcore-watchshop\Views\Shared\_PartialFooter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb2bf489a92b53b06b819973f27f7b554f9645ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialFooter), @"mvc.1.0.view", @"/Views/Shared/_PartialFooter.cshtml")]
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
#line 1 "C:\Users\TOAN\Srouce\aspcore-watchshop\Views\_ViewImports.cshtml"
using aspcore_watchshop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TOAN\Srouce\aspcore-watchshop\Views\_ViewImports.cshtml"
using aspcore_watchshop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb2bf489a92b53b06b819973f27f7b554f9645ce", @"/Views/Shared/_PartialFooter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcc9903d68fd33c13bb283de0d0301e562f01f82", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialFooter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<footer>\r\n");
#nullable restore
#line 2 "C:\Users\TOAN\Srouce\aspcore-watchshop\Views\Shared\_PartialFooter.cshtml"
      
        var polies = ViewData["Polies"];
        var infoStore = ViewData["InfoStore"];
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!--Policy-->
    <div class=""container policy mb-4"">
        <div class=""row"">
            <div class=""col-12 col-lg-6 pb-4"">
                <div class=""policy-item border-black"">
                    <span class=""policy-icon"">
                        <svg height=""30"" width=""30"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 512 512""><path d=""M309 390H27c-15 0-27-12-27-27V95c0-15 12-27 27-27h256c15 0 26 12 26 27v295z"" fill=""#ffd15c""/><path d=""M505 218l-69-69c-4-4-10-7-17-7H309v248h175c15 0 28-12 28-27V235c0-8-2-13-7-17z"" fill=""#f3705a""/><path d=""M0 343v20c0 15 12 26 27 26h457c15 0 28-12 28-27v-20H0v1z"" fill=""#344a5e""/><g fill=""#415a6b""><path d=""M476 272v-33l-61-62h-69v95z""/><circle cx=""130.1"" cy=""377.6"" r=""66.1""/></g><circle cx=""130.1"" cy=""377.6"" r=""32"" fill=""#e8eae9""/><circle cx=""398.9"" cy=""377.6"" r=""66.1"" fill=""#415a6b""/><circle cx=""398.9"" cy=""377.6"" r=""32"" fill=""#e8eae9""/><g fill=""#f7b64c""><path d=""M67 113c-13 0-23 11-23 24v137c0 13 10 24 23 24s24-11 24-24V137c-1-13-11-24-24-24zM154 113c-13 0-2");
            WriteLiteral(@"4 11-24 24v137c0 13 11 24 24 24 12 0 23-11 23-24V137c-1-13-11-24-23-24zM240 113c-13 0-23 11-23 24v137c0 13 10 24 23 24s23-11 23-24V137c-1-13-10-24-23-24z""/></g></svg>
                    </span>
                    <div class=""bold"">
                        <h5> Vận chuyển miễn phí toàn quốc </h5>
                        <p class=""text-sub mb-0"">khi  mua từ 2 sản phẩm</p>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-lg-6 pb-4"">
                <div class=""policy-item border-black"">
                    <span class=""policy-icon"">
                        <svg height=""30"" width=""30"" viewBox=""0 0 512 512""  xmlns=""http://www.w3.org/2000/svg""><path d=""M256 0c-66 0-120 55-120 121l30 30h180l30-30C376 55 322 0 256 0z"" fill=""#5b5555""/><path d=""M376 121C376 55 322 0 256 0v151h90z"" fill=""#463f3f""/><path d=""M196 211h-90v-90h60l30 26z"" fill=""#f73""/><path d=""M406 211h-90v-69l30-21h60z"" fill=""#e64d2e""/><path d=""M484 512h-93l-30-30H151l-30 30H28l26-158c6-30 ");
            WriteLiteral(@"29-55 60-61l49-10 93 87 93-87 49 10c31 6 54 31 60 61z"" fill=""#f73""/><path d=""M484 512h-93l-30-30H256V370l93-87 49 10c31 6 54 31 60 61z"" fill=""#e64d2e""/><path d=""M316 277l-60 45-60-45-33 6 93 117 93-117z"" fill=""#5b5555""/><path d=""M316 277l-60 45v78l93-117z"" fill=""#463f3f""/><path d=""M313 276c-7-1-12-7-12-15v-13h-90v13c0 8-5 14-12 15l-3 1 60 75 60-75z"" fill=""#ffbfab""/><path d=""M313 276c-7-1-12-7-12-15v-13h-45v104l60-75z"" fill=""#f89580""/><path d=""M346 121h-45a76 76 0 01-60-30 75 75 0 01-60 30h-15v60a90 90 0 00175 30l-25-15 30-15z"" fill=""#ffe1ba""/><path d=""M341 211l-25-15 30-15v-60h-45c-17 0-32-6-45-15v165c39 0 72-25 85-60z"" fill=""#ffbfab""/><path d=""M256 181v30h85c3-9 5-19 5-30z"" fill=""#463f3f""/><path d=""M256 361H121v151h270V361z"" fill=""#f0f7ff""/><path d=""M256 361h135v151H256z"" fill=""#dfe7f4""/><path d=""M256 421h-15v30h30v-30z"" fill=""#766e6e""/><path d=""M256 421h15v30h-15z"" fill=""#5b5555""/></svg>
                    </span>
                    <div class=""policy-text bold"">
                        <h5> Hỗ Trợ (9:");
            WriteLiteral(@"00 - 21:00) </h5>
                        <p class=""text-sub mb-0"">087.456.1237</p>
                    </div>
                </div>  
            </div>
        </div>
    </div>
    <!--Footer-->
    <div class=""container-fluid bg-black white pt-5 pb-3 px-5"">
        <div class=""row"">
            <div class=""col-12 col-lg-4 mb-3"">
                <h4 class=""mb-3"">Thông tin cửa hàng</h4>
                <p class=""pr-5"">
                    WathchShop cung cấp sản phẩm với chất lượng đảm bảo, giá cạnh tranh, uy tín. Các sản phẩm chủ đạo : áo khoác, áo sơ mi, áo thun, đồ bộ, quần, .. Luôn đặt khách hàng là trung tâm, để lắng nghe, chia sẻ và liên tục đổi mới.
                </p>
            </div>
            <div class=""col-12 col-lg-2 mb-3"">
                <h4 class=""mb-3"">Liên kế Website</h4>
                <a class=""d-block mb-3"" href=""/khuyen-mai"" title=""Khuyễn mãi"">Khuyễn mãi</a>
                <a class=""d-block mb-3"" href=""/dong-ho-nam"" title=""Đồng hồ nam"">Đồng hồ nam</a>
      ");
            WriteLiteral(@"          <a class=""d-block mb-3"" href=""/dong-ho-nu"" title=""Đồng hồ nữ"">Đồng hồ nữ</a>
                <a class=""d-block mb-3"" href=""/dong-ho-doi"" title=""Đồng hồ đôi"" >Đồng hồ đôi</a>
                <a class=""d-block mb-3"" href=""/phu-kien"" title=""Phụ kiện"">Phụ kiện</a>
            </div>
            <div class=""col-12 col-lg-3 mb-3"">
                <h4 class=""mb-3"">Thông tin liên hệ</h4>
                <p class=""middle-inline"">
                    <i class=""big-icon las la-envelope pr-1""></i>
                    <span id=""email"">dangtoan030@gmail.com</span>                
                </p>
                <p class=""middle-inline"">
                    <i class=""big-icon las la-phone-volume pr-1""></i>
                    <span id=""phone"">0978.456.121</span>                
                </p>
                <p class=""middle-inline"">
                    <i class=""big-icon lab la-facebook-square pr-1""></i>
                    <a id=""fb"" href=""#"" title=""Facebook"">fb.com/dangviettoan99</a> ");
            WriteLiteral(@"               
                </p>
                <p class=""middle-inline"">
                    <i class=""big-icon lab la-instagram pr-1""></i>
                    <a id=""location"" href=""#"" title=""Instargram"">instargram.com/qưuehqwjeo</a>                
                </p>
                <p class=""middle-inline"">
                    <i class=""big-icon las la-map-marked""></i>
                    <span id=""location"">123 Nguyễn Tri Phương, P8, Quận 10, TP.HCM</span>                
                </p>
            </div>
            <div class=""col-12 col-lg-3 mb-3"">
                <h4 class=""mb-3"">Fanpage</h4>
                <div class=""fb-page"" data-href=""https://www.facebook.com/hmh0908.19"" data-tabs=""timeline"" data-width="""" data-height=""280"" data-small-header=""false"" data-adapt-container-width=""true"" data-hide-cover=""false"" data-show-facepile=""true""><blockquote cite=""https://www.facebook.com/hmh0908.19"" class=""fb-xfbml-parse-ignore""><a href=""https://www.facebook.com/hmh0908.19"">Homer Hous");
            WriteLiteral("e</a></blockquote></div>\r\n            </div>\r\n        </div>\r\n        <p class=\"text-center text-sub mb-0\">&copy; Copyright, Watch Shop by vtoandev, 2020</p>    \r\n    </div>\r\n</footer>");
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
