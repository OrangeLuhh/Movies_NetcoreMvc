#pragma checksum "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Movies/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29ee594a5b91f9d7640f0a1bd211ad6f94b603d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Edit), @"mvc.1.0.view", @"/Views/Movies/Edit.cshtml")]
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
#line 1 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/_ViewImports.cshtml"
using NetcoreMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/_ViewImports.cshtml"
using NetcoreMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29ee594a5b91f9d7640f0a1bd211ad6f94b603d9", @"/Views/Movies/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2070e98dc5a99acc8f57e06fdc101ce5d518800", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BasicASP.NETMvc.Models.Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Movies/Edit.cshtml"
  
    ViewBag.Title = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Edit</h2>\n\n\n");
#nullable restore
#line 10 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Movies/Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Movies/Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\n        <h4>Movie</h4>\n        <hr />\n        ");
#nullable restore
#line 17 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Movies/Edit.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 18 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Movies/Edit.cshtml"
   Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 21 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Movies/Edit.cshtml"
       Write(Html.LabelFor(model => model.Title, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
#nullable restore
#line 23 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Movies/Edit.cshtml"
           Write(Html.EditorFor(model => model.Title, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 24 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Movies/Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 29 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Movies/Edit.cshtml"
       Write(Html.LabelFor(model => model.ReleaseDate, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
#nullable restore
#line 31 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Movies/Edit.cshtml"
           Write(Html.EditorFor(model => model.ReleaseDate, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 32 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Movies/Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.ReleaseDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 37 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Movies/Edit.cshtml"
       Write(Html.LabelFor(model => model.Genre, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
#nullable restore
#line 39 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Movies/Edit.cshtml"
           Write(Html.EditorFor(model => model.Genre, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 40 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Movies/Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Genre, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 45 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Movies/Edit.cshtml"
       Write(Html.LabelFor(model => model.Price, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
#nullable restore
#line 47 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Movies/Edit.cshtml"
           Write(Html.EditorFor(model => model.Price, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 48 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Movies/Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Price, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            ");
#nullable restore
#line 53 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Movies/Edit.cshtml"
       Write(Html.LabelFor(model => model.Rating, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <div class=\"col-md-10\">\n                ");
#nullable restore
#line 55 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Movies/Edit.cshtml"
           Write(Html.EditorFor(model => model.Rating, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 56 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Movies/Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Rating, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            <div class=\"col-md-offset-2 col-md-10\">\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 66 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Movies/Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n    ");
#nullable restore
#line 69 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Movies/Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BasicASP.NETMvc.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
