#pragma checksum "C:\Users\mfe06\source\repos\ImageSelect\ImageSelect\Views\Experience\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35e3e51838fd74430df6e7379e8b3e0874ef7e46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Experience_Index), @"mvc.1.0.view", @"/Views/Experience/Index.cshtml")]
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
#line 1 "C:\Users\mfe06\source\repos\ImageSelect\ImageSelect\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mfe06\source\repos\ImageSelect\ImageSelect\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mfe06\source\repos\ImageSelect\ImageSelect\Views\Experience\Index.cshtml"
using EntityLayer.Concreate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35e3e51838fd74430df6e7379e8b3e0874ef7e46", @"/Views/Experience/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Experience_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Experience>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
#nullable restore
#line 4 "C:\Users\mfe06\source\repos\ImageSelect\ImageSelect\Views\Experience\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""card-header border-0"">
    <h3 class=""mt-1"">Yetenek Tablosu</h3>
</div>
<!-- Light table -->

<div class=""table-responsive"">
    <table class=""table align-items-center table-flush"">
        <thead class=""thead-light"">
            <tr>
                <th scope=""col"" class=""sort"" data-sort=""name"">#</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Başlık</th>
                <th scope=""col"" class=""sort"" data-sort=""status"">Tarih</th>
                <th scope=""col"">Sil</th>
                <th scope=""col"" class=""sort"" data-sort=""completion"">Güncelle</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody class=""list"">
");
#nullable restore
#line 28 "C:\Users\mfe06\source\repos\ImageSelect\ImageSelect\Views\Experience\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <th>\r\n                        ");
#nullable restore
#line 33 "C:\Users\mfe06\source\repos\ImageSelect\ImageSelect\Views\Experience\Index.cshtml"
                   Write(item.ExperinceId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 36 "C:\Users\mfe06\source\repos\ImageSelect\ImageSelect\Views\Experience\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n                    <td>\r\n                      ");
#nullable restore
#line 40 "C:\Users\mfe06\source\repos\ImageSelect\ImageSelect\Views\Experience\Index.cshtml"
                 Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    \r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1294, "\"", 1347, 2);
            WriteAttributeValue("", 1301, "/Experience/DeleteExperience/", 1301, 29, true);
#nullable restore
#line 44 "C:\Users\mfe06\source\repos\ImageSelect\ImageSelect\Views\Experience\Index.cshtml"
WriteAttributeValue("", 1330, item.ExperinceId, 1330, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a>\r\n                    </td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1468, "\"", 1521, 2);
            WriteAttributeValue("", 1475, "/Experience/UpdateExperience/", 1475, 29, true);
#nullable restore
#line 47 "C:\Users\mfe06\source\repos\ImageSelect\ImageSelect\Views\Experience\Index.cshtml"
WriteAttributeValue("", 1504, item.ExperinceId, 1504, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 50 "C:\Users\mfe06\source\repos\ImageSelect\ImageSelect\Views\Experience\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <a href=\"/Experience/AddExperience\" class=\"btn btn-dark\">Yeni Deneyim Ekle</a>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Experience>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
