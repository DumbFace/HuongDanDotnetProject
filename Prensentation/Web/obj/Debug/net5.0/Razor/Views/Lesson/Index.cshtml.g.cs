#pragma checksum "D:\WorkSpace\repo\Github\HuongDanDotnetProject\HuongDanDotnetProject\Prensentation\Web\Views\Lesson\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "032c73ded19d57aac5ec8d84284c81be7229f93a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lesson_Index), @"mvc.1.0.view", @"/Views/Lesson/Index.cshtml")]
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
#line 1 "D:\WorkSpace\repo\Github\HuongDanDotnetProject\HuongDanDotnetProject\Prensentation\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WorkSpace\repo\Github\HuongDanDotnetProject\HuongDanDotnetProject\Prensentation\Web\Views\_ViewImports.cshtml"
using CMS.Core.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WorkSpace\repo\Github\HuongDanDotnetProject\HuongDanDotnetProject\Prensentation\Web\Views\_ViewImports.cshtml"
using Web.Factory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\WorkSpace\repo\Github\HuongDanDotnetProject\HuongDanDotnetProject\Prensentation\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"032c73ded19d57aac5ec8d84284c81be7229f93a", @"/Views/Lesson/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"484e90947bd39645268e34b584097a365c8205b7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Lesson_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container default-background-color m-b-30\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-4\">\r\n            ");
#nullable restore
#line 4 "D:\WorkSpace\repo\Github\HuongDanDotnetProject\HuongDanDotnetProject\Prensentation\Web\Views\Lesson\Index.cshtml"
       Write(await Component.InvokeAsync("SideBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <div class=""col-sm-8"">
            <section class=""content content-course default-padding"" id=""content"">
                <h1 class=""h1-content-lesson"">Introduction to C#</h1>
                <p>Quay lại: <a href=""#"">Hướng Dẫn .NET C# cho người mới bắt đầu </a></p>

                <h2>
                    .NET Framework là gì ?
                </h2>
            </section>

            <div class=""nav-content default-padding"">
                <a href=""#"" class=""blog-nav-lesson previous-lesson"" title=""Temp Data trước"">
                    <p>
                        <i class=""fa fa-angle-left""></i>
                        Bài học trước
                    </p>
                    <h3>Temp Data</h3>
                </a>
                <a href=""#"" class=""blog-nav-lesson next-lesson"" title=""Temp Data tiếp theo"">
                    <p>
                        Bài học sau
                        <i class=""fa fa-angle-right""></i>
                    </p>
            ");
            WriteLiteral("        <h3>Temp Data</h3>\r\n                </a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
