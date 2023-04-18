#pragma checksum "E:\Workspace\Repo\Github\HuongDanDotNet\Prensentation\Web\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "754be63d77395e76d2567db14782736f3d253738"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "E:\Workspace\Repo\Github\HuongDanDotNet\Prensentation\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Workspace\Repo\Github\HuongDanDotNet\Prensentation\Web\Views\_ViewImports.cshtml"
using CMS.Core.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Workspace\Repo\Github\HuongDanDotNet\Prensentation\Web\Views\_ViewImports.cshtml"
using Web.Factory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Workspace\Repo\Github\HuongDanDotNet\Prensentation\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"754be63d77395e76d2567db14782736f3d253738", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"484e90947bd39645268e34b584097a365c8205b7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_header", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_footer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
#nullable restore
#line 4 "E:\Workspace\Repo\Github\HuongDanDotNet\Prensentation\Web\Views\Shared\_Layout.cshtml"
  
    string Title = ViewBag.Title != null ? ViewBag.Title : "Blog Thủ Thuật | Chia sẽ các thủ thuật về công nghệ";
    string Description = ViewBag.Description != null ? ViewBag.Description : "Blog Thủ Thuật | Chia sẽ các thủ thuật về công nghệ";
    string Url = ViewBag.Url != null ? ViewBag.Url : "https://phamphuongkhang.xyz";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "754be63d77395e76d2567db14782736f3d2537384915", async() => {
                WriteLiteral("\r\n    <link rel=\"icon\" href=\"https://phamphuongkhang.xyz/images/logo.png\" type=\"image/icon type\">\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>\r\n        ");
#nullable restore
#line 14 "E:\Workspace\Repo\Github\HuongDanDotNet\Prensentation\Web\Views\Shared\_Layout.cshtml"
   Write(Html.Raw(Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </title>\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", "\r\n        content=\"", 671, "\"", 712, 1);
#nullable restore
#line 17 "E:\Workspace\Repo\Github\HuongDanDotNet\Prensentation\Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 690, Html.Raw(Description), 690, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
    <meta name=""google-site-verification"" content=""n7-Sc3A7Znnok_1AAeUhdBhjcStPTVQ07kGtv9v-mvE"" />
    <meta name=""google-site-verification"" content=""2yLc0cvYrHTy2eHVWlNzLQew7Bcg5TfZ8gkMReAH-4A"" />
    <link rel=""canonical"" href=""https://phamphuongkhang.xyz/"" />
    <meta content=""index,follow"" name=""robots"" />
    <meta property=""og:title""");
                BeginWriteAttribute("content", " content=\"", 1062, "\"", 1088, 1);
#nullable restore
#line 22 "E:\Workspace\Repo\Github\HuongDanDotNet\Prensentation\Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1072, Html.Raw(Title), 1072, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta property=\"og:description\"");
                BeginWriteAttribute("content", " content=\"", 1129, "\"", 1161, 1);
#nullable restore
#line 23 "E:\Workspace\Repo\Github\HuongDanDotNet\Prensentation\Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1139, Html.Raw(Description), 1139, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta property=\"og:url\"");
                BeginWriteAttribute("content", " content=\"", 1194, "\"", 1218, 1);
#nullable restore
#line 24 "E:\Workspace\Repo\Github\HuongDanDotNet\Prensentation\Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1204, Html.Raw(Url), 1204, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
    <meta property=""og:type"" content=""article"" />
    <meta property=""og:image"" content=""https://phamphuongkhang.xyz/images/logo.png"" />
    <meta property=""og:image:width"" content=""1200"" />
    <meta property=""og:image:height"" content=""628"" />

    <link rel=""stylesheet"" href=""/css/style.css"">
    <!-- Google tag (gtag.js) -->
    <script async src=""https://www.googletagmanager.com/gtag/js?id=G-R51RZ8YNQH""></script>
    <script>
        window.dataLayer = window.dataLayer || [];
        function gtag() { dataLayer.push(arguments); }
        gtag('js', new Date());

        gtag('config', 'G-R51RZ8YNQH');
    </script>



");
#nullable restore
#line 43 "E:\Workspace\Repo\Github\HuongDanDotNet\Prensentation\Web\Views\Shared\_Layout.cshtml"
      if (ViewBag.Reading != 1)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <script type=\"application/ld+json\">\r\n        {\r\n        \"");
                WriteLiteral("@context\": \"https://schema.org\",\r\n        \"");
                WriteLiteral(@"@type""   : ""Organization"",
        ""name""     :""Blog Thủ Thuật | Chia sẽ các thủ thuật về công nghệ"",
        ""url""      : ""https://phamphuongkhang.xyz/"",
        ""logo""     : ""https://phamphuongkhang.xyz/images/logo.png"",
        ""contactPoint"": [
        {
        """);
                WriteLiteral("@type\": \"ContactPoint\",\r\n        \"contactType\": \"customer service\"\r\n        }\r\n        ],\r\n");
                WriteLiteral("        \"foundingDate\"  :\"2023\",\r\n        \"address\" : [\r\n        {\r\n        \"");
                WriteLiteral("@type\"    :\"PostalAddress\",\r\n        \"addressLocality\":\"Hồ Chí Minh City\",\r\n        \"addressCountry\": \"Việt Nam\",\r\n        \"postalCode\":\"72209\",\r\n        \"email\":\"gv.runfast@gmail.com\"\r\n        }\r\n        ]\r\n        }\r\n    </script>\r\n");
#nullable restore
#line 71 "E:\Workspace\Repo\Github\HuongDanDotNet\Prensentation\Web\Views\Shared\_Layout.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <script type=\"application/ld+json\">\r\n    {\r\n    \"");
                WriteLiteral("@context\": \"https://schema.org\",\r\n    \"");
                WriteLiteral("@type\": \"Article\",\r\n    \"mainEntityOfPage\":    [    {    \"");
                WriteLiteral("@type\":\"WebPage\",    \"");
                WriteLiteral("@id\":\"");
#nullable restore
#line 78 "E:\Workspace\Repo\Github\HuongDanDotNet\Prensentation\Web\Views\Shared\_Layout.cshtml"
                                                               Write(ViewBag.FriendlyUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"    }    ],\r\n    \"description\": \"");
#nullable restore
#line 79 "E:\Workspace\Repo\Github\HuongDanDotNet\Prensentation\Web\Views\Shared\_Layout.cshtml"
               Write(Html.Raw(ViewBag.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n    \"headline\": \"");
#nullable restore
#line 80 "E:\Workspace\Repo\Github\HuongDanDotNet\Prensentation\Web\Views\Shared\_Layout.cshtml"
            Write(Html.Raw(ViewBag.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n    \"datePublished\": \"");
#nullable restore
#line 81 "E:\Workspace\Repo\Github\HuongDanDotNet\Prensentation\Web\Views\Shared\_Layout.cshtml"
                 Write(ViewBag.DatePublish);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n    \"dateModified\": \"");
#nullable restore
#line 82 "E:\Workspace\Repo\Github\HuongDanDotNet\Prensentation\Web\Views\Shared\_Layout.cshtml"
                Write(ViewBag.DateModified);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n");
                WriteLiteral("    \"publisher\": {\r\n    \"");
                WriteLiteral("@type\": \"Organization\",\r\n    \"name\": \"Blog Thủ Thuật | Chia sẽ các thủ thuật về công nghệ\",\r\n    \"logo\": {\r\n        \"");
                WriteLiteral("@type\": \"ImageObject\",\r\n        \"url\": \"https://phamphuongkhang.xyz/images/logo.png\"\r\n    }\r\n    },\r\n    \"image\": {\r\n        \"");
                WriteLiteral("@type\": \"ImageObject\",\r\n        \"url\": \"");
#nullable restore
#line 97 "E:\Workspace\Repo\Github\HuongDanDotNet\Prensentation\Web\Views\Shared\_Layout.cshtml"
           Write(ViewBag.Thumb);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n        }\r\n    }\r\n</script>\r\n");
#nullable restore
#line 101 "E:\Workspace\Repo\Github\HuongDanDotNet\Prensentation\Web\Views\Shared\_Layout.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "754be63d77395e76d2567db14782736f3d25373813360", async() => {
                WriteLiteral("\r\n    <div id=\"wrapper\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "754be63d77395e76d2567db14782736f3d25373813655", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
#nullable restore
#line 107 "E:\Workspace\Repo\Github\HuongDanDotNet\Prensentation\Web\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "754be63d77395e76d2567db14782736f3d25373815080", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n\r\n    <!-- include jQuery -->\r\n    <script src=\"/js/jquery.js\"></script>\r\n    <!-- include jQuery -->\r\n    <script src=\"/js/plugins.js\"></script>\r\n    <!-- include jQuery -->\r\n    <script src=\"/js/jquery.main.js\"></script>\r\n    ");
#nullable restore
#line 117 "E:\Workspace\Repo\Github\HuongDanDotNet\Prensentation\Web\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
