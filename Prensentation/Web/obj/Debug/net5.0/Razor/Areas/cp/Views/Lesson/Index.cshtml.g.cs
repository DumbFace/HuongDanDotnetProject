#pragma checksum "D:\WorkSpace\repo\Github\HuongDanDotnetProject\HuongDanDotnetProject\Prensentation\Web\Areas\cp\Views\Lesson\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a4d5afba619481168c7532ba03338dd2593dc17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_cp_Views_Lesson_Index), @"mvc.1.0.view", @"/Areas/cp/Views/Lesson/Index.cshtml")]
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
#line 1 "D:\WorkSpace\repo\Github\HuongDanDotnetProject\HuongDanDotnetProject\Prensentation\Web\Areas\cp\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WorkSpace\repo\Github\HuongDanDotnetProject\HuongDanDotnetProject\Prensentation\Web\Areas\cp\Views\_ViewImports.cshtml"
using CMS.Core.Domain.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WorkSpace\repo\Github\HuongDanDotnetProject\HuongDanDotnetProject\Prensentation\Web\Areas\cp\Views\_ViewImports.cshtml"
using CMS.Core.Domain.Courses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\WorkSpace\repo\Github\HuongDanDotnetProject\HuongDanDotnetProject\Prensentation\Web\Areas\cp\Views\_ViewImports.cshtml"
using CMS.Core.Domain.Lessons;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a4d5afba619481168c7532ba03338dd2593dc17", @"/Areas/cp/Views/Lesson/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1568c7da2d3ecc61d103592aba3b11680cba5e6e", @"/Areas/cp/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_cp_Views_Lesson_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lesson>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Status", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Status"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<input type=\"hidden\" id=\"DateCreated\" name=\"DateCreated\"");
            BeginWriteAttribute("value", " value=\"", 73, "\"", 99, 1);
#nullable restore
#line 3 "D:\WorkSpace\repo\Github\HuongDanDotnetProject\HuongDanDotnetProject\Prensentation\Web\Areas\cp\Views\Lesson\Index.cshtml"
WriteAttributeValue("", 81, Model.DateCreated, 81, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n<input type=\"hidden\" id=\"DateModified\" name=\"DateModified\"");
            BeginWriteAttribute("value", " value=\"", 161, "\"", 188, 1);
#nullable restore
#line 4 "D:\WorkSpace\repo\Github\HuongDanDotnetProject\HuongDanDotnetProject\Prensentation\Web\Areas\cp\Views\Lesson\Index.cshtml"
WriteAttributeValue("", 169, Model.DateModified, 169, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n<input type=\"hidden\" id=\"Id\" name=\"Id\"");
            BeginWriteAttribute("value", " value=\"", 230, "\"", 247, 1);
#nullable restore
#line 5 "D:\WorkSpace\repo\Github\HuongDanDotnetProject\HuongDanDotnetProject\Prensentation\Web\Areas\cp\Views\Lesson\Index.cshtml"
WriteAttributeValue("", 238, Model.Id, 238, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n<div class=\"form-group\">\r\n    <label for=\"Title\">Tiêu đề bài học</label>\r\n    <input type=\"text\" class=\"form-control\" id=\"Title\" name=\"Title\" placeholder=\"Nhập tiêu đề\"");
            BeginWriteAttribute("value", " value=\"", 419, "\"", 439, 1);
#nullable restore
#line 8 "D:\WorkSpace\repo\Github\HuongDanDotnetProject\HuongDanDotnetProject\Prensentation\Web\Areas\cp\Views\Lesson\Index.cshtml"
WriteAttributeValue("", 427, Model.Title, 427, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n</div>\r\n<div class=\"form-group\">\r\n    <label for=\"Url\">Nhập Url</label>\r\n    <input type=\"text\" class=\"form-control\" id=\"Url\" name=\"Url\" placeholder=\"Nhập Url\"");
            BeginWriteAttribute("value", " value=\"", 602, "\"", 620, 1);
#nullable restore
#line 12 "D:\WorkSpace\repo\Github\HuongDanDotnetProject\HuongDanDotnetProject\Prensentation\Web\Areas\cp\Views\Lesson\Index.cshtml"
WriteAttributeValue("", 610, Model.Url, 610, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n</div>\r\n<div class=\"form-group\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a4d5afba619481168c7532ba03338dd2593dc177439", async() => {
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 17 "D:\WorkSpace\repo\Github\HuongDanDotnetProject\HuongDanDotnetProject\Prensentation\Web\Areas\cp\Views\Lesson\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Html.GetEnumSelectList<StatusCode>();

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-sm-2\">\r\n            <input type=\"number\" class=\"form-control\" id=\"Order\" name=\"Order\"");
            BeginWriteAttribute("value", " value=\"", 979, "\"", 999, 1);
#nullable restore
#line 21 "D:\WorkSpace\repo\Github\HuongDanDotnetProject\HuongDanDotnetProject\Prensentation\Web\Areas\cp\Views\Lesson\Index.cshtml"
WriteAttributeValue("", 987, Model.Order, 987, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"form-group\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-12\">\r\n            <div class=\"document-editor__toolbar\"></div>\r\n            <div id=\"editor\">\r\n                ");
#nullable restore
#line 30 "D:\WorkSpace\repo\Github\HuongDanDotnetProject\HuongDanDotnetProject\Prensentation\Web\Areas\cp\Views\Lesson\Index.cshtml"
           Write(Html.Raw(Model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<button type=\"button\" onclick=\"UpdateLesson()\" class=\"btn btn-primary\">Lưu</button>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        var editor = new RichTextEditor(\"#editor\");\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lesson> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
