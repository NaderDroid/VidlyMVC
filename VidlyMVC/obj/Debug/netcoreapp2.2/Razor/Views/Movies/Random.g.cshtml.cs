#pragma checksum "/Users/naderalthubaity/Projects/VidlyMVC/VidlyMVC/Views/Movies/Random.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af13ca82db1572d43ab82004807157550d163058"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Random), @"mvc.1.0.view", @"/Views/Movies/Random.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movies/Random.cshtml", typeof(AspNetCore.Views_Movies_Random))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af13ca82db1572d43ab82004807157550d163058", @"/Views/Movies/Random.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea10cdccc6cdfb68f8ee5a78290d566f9b08b391", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Random : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VidlyMVC.ViewModels.RandomMovieViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/naderalthubaity/Projects/VidlyMVC/VidlyMVC/Views/Movies/Random.cshtml"
  
    ViewBag.Title = "Random";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 6 "/Users/naderalthubaity/Projects/VidlyMVC/VidlyMVC/Views/Movies/Random.cshtml"
  

    var className = Model.Customers.Count > 3 ? "popular" : null;

#line default
#line hidden
            BeginContext(211, 5, true);
            WriteLiteral("\r\n<h2");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 216, "\"", 234, 1);
#line 11 "/Users/naderalthubaity/Projects/VidlyMVC/VidlyMVC/Views/Movies/Random.cshtml"
WriteAttributeValue("", 224, className, 224, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(235, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(237, 16, false);
#line 11 "/Users/naderalthubaity/Projects/VidlyMVC/VidlyMVC/Views/Movies/Random.cshtml"
                  Write(Model.Movie.Name);

#line default
#line hidden
            EndContext();
            BeginContext(253, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
#line 13 "/Users/naderalthubaity/Projects/VidlyMVC/VidlyMVC/Views/Movies/Random.cshtml"
 if (Model.Customers.Count == 0)
{
    

#line default
#line hidden
            BeginContext(309, 39, true);
            WriteLiteral(" This movie has not been rented before ");
            EndContext();
#line 15 "/Users/naderalthubaity/Projects/VidlyMVC/VidlyMVC/Views/Movies/Random.cshtml"
                                                        
}
else
{


#line default
#line hidden
            BeginContext(371, 10, true);
            WriteLiteral("    <ul>\r\n");
            EndContext();
#line 21 "/Users/naderalthubaity/Projects/VidlyMVC/VidlyMVC/Views/Movies/Random.cshtml"
         foreach (var customer in Model.Customers)
        {

#line default
#line hidden
            BeginContext(444, 34, true);
            WriteLiteral("            <li>\r\n                ");
            EndContext();
            BeginContext(479, 13, false);
#line 24 "/Users/naderalthubaity/Projects/VidlyMVC/VidlyMVC/Views/Movies/Random.cshtml"
           Write(customer.Name);

#line default
#line hidden
            EndContext();
            BeginContext(492, 21, true);
            WriteLiteral("\r\n            </li>\r\n");
            EndContext();
#line 26 "/Users/naderalthubaity/Projects/VidlyMVC/VidlyMVC/Views/Movies/Random.cshtml"
        }

#line default
#line hidden
            BeginContext(524, 11, true);
            WriteLiteral("    </ul>\r\n");
            EndContext();
#line 28 "/Users/naderalthubaity/Projects/VidlyMVC/VidlyMVC/Views/Movies/Random.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VidlyMVC.ViewModels.RandomMovieViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
