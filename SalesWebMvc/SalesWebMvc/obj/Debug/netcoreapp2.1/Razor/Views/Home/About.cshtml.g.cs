#pragma checksum "F:\Udemy\C# Nélio Alves\18-Proj Sistema Web Com Asp.Net Core MVC e Entity e FrameWork\MVC\SalesWebMvc\SalesWebMvc\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4130555cee6d57aebadbee7ec215a4edfff23756"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "F:\Udemy\C# Nélio Alves\18-Proj Sistema Web Com Asp.Net Core MVC e Entity e FrameWork\MVC\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc;

#line default
#line hidden
#line 2 "F:\Udemy\C# Nélio Alves\18-Proj Sistema Web Com Asp.Net Core MVC e Entity e FrameWork\MVC\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4130555cee6d57aebadbee7ec215a4edfff23756", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70dafd425af89a5439216963c7093f2ead686e4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "F:\Udemy\C# Nélio Alves\18-Proj Sistema Web Com Asp.Net Core MVC e Entity e FrameWork\MVC\SalesWebMvc\SalesWebMvc\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(41, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(46, 17, false);
#line 4 "F:\Udemy\C# Nélio Alves\18-Proj Sistema Web Com Asp.Net Core MVC e Entity e FrameWork\MVC\SalesWebMvc\SalesWebMvc\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(63, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(75, 19, false);
#line 5 "F:\Udemy\C# Nélio Alves\18-Proj Sistema Web Com Asp.Net Core MVC e Entity e FrameWork\MVC\SalesWebMvc\SalesWebMvc\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(94, 11, true);
            WriteLiteral("</h3>\r\n<h3>");
            EndContext();
            BeginContext(106, 17, false);
#line 6 "F:\Udemy\C# Nélio Alves\18-Proj Sistema Web Com Asp.Net Core MVC e Entity e FrameWork\MVC\SalesWebMvc\SalesWebMvc\Views\Home\About.cshtml"
Write(ViewData["Email"]);

#line default
#line hidden
            EndContext();
            BeginContext(123, 37, true);
            WriteLiteral("</h3>\r\n\r\n\r\n<p><strong>Autor:</strong>");
            EndContext();
            BeginContext(161, 17, false);
#line 9 "F:\Udemy\C# Nélio Alves\18-Proj Sistema Web Com Asp.Net Core MVC e Entity e FrameWork\MVC\SalesWebMvc\SalesWebMvc\Views\Home\About.cshtml"
                     Write(ViewData["Autor"]);

#line default
#line hidden
            EndContext();
            BeginContext(178, 150, true);
            WriteLiteral("</p>\r\n\r\n<address>\r\n<strong>Mais informações:</strong>\r\n    <a href=\"https://github.com/HudneyGN/ControlSales\">Projeto vendas no GitHub</a>\r\n</address>");
            EndContext();
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
