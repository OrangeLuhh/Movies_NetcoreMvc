#pragma checksum "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Auth/Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e25edd343f612c585cd61092aefdb63b90b3c12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Login), @"mvc.1.0.view", @"/Views/Auth/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e25edd343f612c585cd61092aefdb63b90b3c12", @"/Views/Auth/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2070e98dc5a99acc8f57e06fdc101ce5d518800", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BasicASP.NETMvc.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>login</h2>\r\n\r\n");
#nullable restore
#line 5 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Auth/Login.cshtml"
 using (Html.BeginForm("Login", "Auth", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Auth/Login.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Auth/Login.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 class=\"form-signin-heading\">User Login</h2>\r\n");
#nullable restore
#line 11 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Auth/Login.cshtml"
Write(Html.TextBoxFor(model => model.UserName, htmlAttributes:new { @class = "form-control", type = "text", placeholder = "userName" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 13 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Auth/Login.cshtml"
Write(Html.PasswordFor(model => model.PassWord, htmlAttributes:new { @class = "form-control", type = "password", placeholder = "Password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 14 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Auth/Login.cshtml"
  Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <button class=\"btn btn-primary\" type=\"submit\">Login</button>            \r\n");
#nullable restore
#line 16 "/Users/haihong.lu/workspace/Movies_NetcoreMvc/NetcoreMvc/Views/Auth/Login.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BasicASP.NETMvc.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
