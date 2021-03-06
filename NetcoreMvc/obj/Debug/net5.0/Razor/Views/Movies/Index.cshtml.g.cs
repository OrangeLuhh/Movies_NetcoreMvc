#pragma checksum "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Movies/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d86ae34344c88a3046f81528f34b1963b0faf88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
#line 1 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/_ViewImports.cshtml"
using NetcoreMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/_ViewImports.cshtml"
using NetcoreMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d86ae34344c88a3046f81528f34b1963b0faf88", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2070e98dc5a99acc8f57e06fdc101ce5d518800", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BasicASP.NETMvc.Models.Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Movies/Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Movies</h2>\n<p>\n\n");
            WriteLiteral("    ");
#nullable restore
#line 9 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Movies/Index.cshtml"
Write(Html.ActionLink("Creat New", "Create", "Movies"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 11 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Movies/Index.cshtml"
     using (Html.BeginForm("Index", "Movies", FormMethod.Get))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\n    Genre: ");
#nullable restore
#line 14 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Movies/Index.cshtml"
      Write(Html.DropDownList("MovieGenre", "All"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    Title: ");
#nullable restore
#line 15 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Movies/Index.cshtml"
      Write(Html.TextBox("SearchString"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <input type=\"submit\" value=\"Filter\" />\n</p>\n");
#nullable restore
#line 18 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Movies/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<table class=\"table\">\n    <tr>\n        <th>\n            ");
#nullable restore
#line 23 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Movies/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 26 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Movies/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 29 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Movies/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 32 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Movies/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 35 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Movies/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n\n        <th></th>\n    </tr>\n");
#nullable restore
#line 41 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Movies/Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 45 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Movies/Index.cshtml"
           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 48 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Movies/Index.cshtml"
           Write(item.ReleaseDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 51 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Movies/Index.cshtml"
           Write(item.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 54 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Movies/Index.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 57 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Movies/Index.cshtml"
           Write(item.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n\n            <td>");
#nullable restore
#line 60 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Movies/Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", "Movies", new{id=@item.ID}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                |");
#nullable restore
#line 61 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Movies/Index.cshtml"
            Write(Html.ActionLink("Details", "Details", "Movies", new{id=@item.ID}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                |");
#nullable restore
#line 62 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Movies/Index.cshtml"
            Write(Html.ActionLink("Delete", "Delete", "Movies", new{id=@item.ID}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 64 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Movies/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BasicASP.NETMvc.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
