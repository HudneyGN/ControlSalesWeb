#pragma checksum "F:\Udemy\C# Nélio Alves\18-Proj Sistema Web Com Asp.Net Core MVC e Entity e FrameWork\MVC\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb0f997c907806bda4325a3d050efb5c10761e34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sellers_Index), @"mvc.1.0.view", @"/Views/Sellers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sellers/Index.cshtml", typeof(AspNetCore.Views_Sellers_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb0f997c907806bda4325a3d050efb5c10761e34", @"/Views/Sellers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70dafd425af89a5439216963c7093f2ead686e4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Sellers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SalesWebMvc.Models.Seller>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Udemy\C# Nélio Alves\18-Proj Sistema Web Com Asp.Net Core MVC e Entity e FrameWork\MVC\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml"
  
    ViewData["Title"] = "Vendedores";

#line default
#line hidden
            BeginContext(95, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(102, 17, false);
#line 7 "F:\Udemy\C# Nélio Alves\18-Proj Sistema Web Com Asp.Net Core MVC e Entity e FrameWork\MVC\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(119, 118, true);
            WriteLiteral("</h2>\r\n\r\n<table class=\"table table-striped table-hover\"\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(238, 40, false);
#line 13 "F:\Udemy\C# Nélio Alves\18-Proj Sistema Web Com Asp.Net Core MVC e Entity e FrameWork\MVC\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(278, 83, true);
            WriteLiteral(" <!--expressão lambida-->\r\n            </th>   \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(362, 41, false);
#line 16 "F:\Udemy\C# Nélio Alves\18-Proj Sistema Web Com Asp.Net Core MVC e Entity e FrameWork\MVC\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(403, 80, true);
            WriteLiteral(" <!--expressão lambida-->\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(484, 45, false);
#line 19 "F:\Udemy\C# Nélio Alves\18-Proj Sistema Web Com Asp.Net Core MVC e Entity e FrameWork\MVC\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(529, 80, true);
            WriteLiteral(" <!--expressão lambida-->\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(610, 46, false);
#line 22 "F:\Udemy\C# Nélio Alves\18-Proj Sistema Web Com Asp.Net Core MVC e Entity e FrameWork\MVC\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Basesalary));

#line default
#line hidden
            EndContext();
            BeginContext(656, 89, true);
            WriteLiteral(" <!--expressão lambida-->\r\n            </th>\r\n        </tr>\r\n    </thead> \r\n    <tbody>\r\n");
            EndContext();
#line 27 "F:\Udemy\C# Nélio Alves\18-Proj Sistema Web Com Asp.Net Core MVC e Entity e FrameWork\MVC\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(794, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(855, 39, false);
#line 31 "F:\Udemy\C# Nélio Alves\18-Proj Sistema Web Com Asp.Net Core MVC e Entity e FrameWork\MVC\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(894, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(962, 40, false);
#line 34 "F:\Udemy\C# Nélio Alves\18-Proj Sistema Web Com Asp.Net Core MVC e Entity e FrameWork\MVC\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1070, 44, false);
#line 37 "F:\Udemy\C# Nélio Alves\18-Proj Sistema Web Com Asp.Net Core MVC e Entity e FrameWork\MVC\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(1114, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1182, 45, false);
#line 40 "F:\Udemy\C# Nélio Alves\18-Proj Sistema Web Com Asp.Net Core MVC e Entity e FrameWork\MVC\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Basesalary));

#line default
#line hidden
            EndContext();
            BeginContext(1227, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 43 "F:\Udemy\C# Nélio Alves\18-Proj Sistema Web Com Asp.Net Core MVC e Entity e FrameWork\MVC\SalesWebMvc\SalesWebMvc\Views\Sellers\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1282, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SalesWebMvc.Models.Seller>> Html { get; private set; }
    }
}
#pragma warning restore 1591
