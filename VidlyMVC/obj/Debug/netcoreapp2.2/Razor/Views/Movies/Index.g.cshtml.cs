#pragma checksum "/Users/naderalthubaity/Projects/VidlyMVC/VidlyMVC/Views/Movies/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0294466a41c71c29107c3aa621999f7acc708380"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movies/Index.cshtml", typeof(AspNetCore.Views_Movies_Index))]
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
#line 1 "/Users/naderalthubaity/Projects/VidlyMVC/VidlyMVC/Views/_ViewImports.cshtml"
using VidlyMVC;

#line default
#line hidden
#line 2 "/Users/naderalthubaity/Projects/VidlyMVC/VidlyMVC/Views/_ViewImports.cshtml"
using VidlyMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0294466a41c71c29107c3aa621999f7acc708380", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea10cdccc6cdfb68f8ee5a78290d566f9b08b391", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VidlyMVC.Models.Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/naderalthubaity/Projects/VidlyMVC/VidlyMVC/Views/Movies/Index.cshtml"
  
    ViewBag.Title = "Movies";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(130, 166, true);
            WriteLiteral("\r\n<h2>Movies</h2>\r\n<table class=\"table table-bordered table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>Movie</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 16 "/Users/naderalthubaity/Projects/VidlyMVC/VidlyMVC/Views/Movies/Index.cshtml"
         foreach (var movie in Model)
        {

#line default
#line hidden
            BeginContext(346, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(385, 10, false);
#line 19 "/Users/naderalthubaity/Projects/VidlyMVC/VidlyMVC/Views/Movies/Index.cshtml"
               Write(movie.Name);

#line default
#line hidden
            EndContext();
            BeginContext(395, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 21 "/Users/naderalthubaity/Projects/VidlyMVC/VidlyMVC/Views/Movies/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(432, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VidlyMVC.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
