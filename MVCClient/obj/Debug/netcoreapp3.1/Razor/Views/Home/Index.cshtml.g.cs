#pragma checksum "C:\Development\IdentityServer\QuickStart-AspNetCore\MVCClient\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b96a9a41cd3acbf4e396accc8a69dac9be4787e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Development\IdentityServer\QuickStart-AspNetCore\MVCClient\Views\_ViewImports.cshtml"
using MVCClient;

#line default
#line hidden
#line 2 "C:\Development\IdentityServer\QuickStart-AspNetCore\MVCClient\Views\_ViewImports.cshtml"
using MVCClient.Models;

#line default
#line hidden
#line 1 "C:\Development\IdentityServer\QuickStart-AspNetCore\MVCClient\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b96a9a41cd3acbf4e396accc8a69dac9be4787e6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e6d0ae0c9d7e6e45ee166fce82a68c9aa028843", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Development\IdentityServer\QuickStart-AspNetCore\MVCClient\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            WriteLiteral("<h2>Claims</h2>\r\n\r\n<dl>\r\n");
#line 8 "C:\Development\IdentityServer\QuickStart-AspNetCore\MVCClient\Views\Home\Index.cshtml"
   foreach (var claim in User.Claims)
  {

#line default
#line hidden
            WriteLiteral("    <dt>");
#line 10 "C:\Development\IdentityServer\QuickStart-AspNetCore\MVCClient\Views\Home\Index.cshtml"
   Write(claim.Type);

#line default
#line hidden
            WriteLiteral("</dt>\r\n    <dd>");
#line 11 "C:\Development\IdentityServer\QuickStart-AspNetCore\MVCClient\Views\Home\Index.cshtml"
   Write(claim.Value);

#line default
#line hidden
            WriteLiteral("</dd>\r\n");
#line 12 "C:\Development\IdentityServer\QuickStart-AspNetCore\MVCClient\Views\Home\Index.cshtml"
  }

#line default
#line hidden
            WriteLiteral("</dl>\r\n\r\n<h2>Properties</h2>\r\n\r\n<dl>\r\n");
#line 18 "C:\Development\IdentityServer\QuickStart-AspNetCore\MVCClient\Views\Home\Index.cshtml"
   foreach (var prop in (await Context.AuthenticateAsync()).Properties.Items)
  {

#line default
#line hidden
            WriteLiteral("    <dt>");
#line 20 "C:\Development\IdentityServer\QuickStart-AspNetCore\MVCClient\Views\Home\Index.cshtml"
   Write(prop.Key);

#line default
#line hidden
            WriteLiteral("</dt>\r\n    <dd>");
#line 21 "C:\Development\IdentityServer\QuickStart-AspNetCore\MVCClient\Views\Home\Index.cshtml"
   Write(prop.Value);

#line default
#line hidden
            WriteLiteral("</dd>\r\n");
#line 22 "C:\Development\IdentityServer\QuickStart-AspNetCore\MVCClient\Views\Home\Index.cshtml"
  }

#line default
#line hidden
            WriteLiteral("</dl>\r\n");
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