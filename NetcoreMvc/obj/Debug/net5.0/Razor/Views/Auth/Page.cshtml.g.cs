#pragma checksum "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Auth/Page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32a08199c330229f5dd9cb41d5928fc15e347f0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Page), @"mvc.1.0.view", @"/Views/Auth/Page.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#nullable restore
#line 1 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Auth/Page.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Auth/Page.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32a08199c330229f5dd9cb41d5928fc15e347f0d", @"/Views/Auth/Page.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2070e98dc5a99acc8f57e06fdc101ce5d518800", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Page : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 6 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Auth/Page.cshtml"
  
    ViewBag.Title = "Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 11 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Auth/Page.cshtml"
  
    // basic points 18  data from Session
    string userName = @_httpContextAccessor.HttpContext.Session.GetString("userName");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<h2>Welcome ");
#nullable restore
#line 17 "/Users/haihong.lu/workspace/NetcoreMvc/NetcoreMvc/Views/Auth/Page.cshtml"
       Write(userName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor _httpContextAccessor { get; private set; }
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