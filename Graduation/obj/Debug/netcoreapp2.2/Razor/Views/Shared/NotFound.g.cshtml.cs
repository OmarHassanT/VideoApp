#pragma checksum "C:\Users\OmarTaradeh\source\repos\Graduation\Graduation\Views\Shared\NotFound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd11c19949687d8ca398c0f3fedd70995db9dc1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_NotFound), @"mvc.1.0.view", @"/Views/Shared/NotFound.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/NotFound.cshtml", typeof(AspNetCore.Views_Shared_NotFound))]
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
#line 1 "C:\Users\OmarTaradeh\source\repos\Graduation\Graduation\Views\_ViewImports.cshtml"
using Graduation;

#line default
#line hidden
#line 2 "C:\Users\OmarTaradeh\source\repos\Graduation\Graduation\Views\_ViewImports.cshtml"
using Graduation.Models;

#line default
#line hidden
#line 3 "C:\Users\OmarTaradeh\source\repos\Graduation\Graduation\Views\_ViewImports.cshtml"
using Graduation.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\OmarTaradeh\source\repos\Graduation\Graduation\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd11c19949687d8ca398c0f3fedd70995db9dc1d", @"/Views/Shared/NotFound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bfc375c5b51fa09a82c4b399f7e6de992f57c94", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_NotFound : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\OmarTaradeh\source\repos\Graduation\Graduation\Views\Shared\NotFound.cshtml"
   
    ViewBag.Title = "NotFound";

#line default
#line hidden
            BeginContext(41, 86, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"container center\">\r\n        <h1  style=\"color:red\">");
            EndContext();
            BeginContext(128, 20, false);
#line 6 "C:\Users\OmarTaradeh\source\repos\Graduation\Graduation\Views\Shared\NotFound.cshtml"
                          Write(ViewBag.ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(148, 27, true);
            WriteLiteral("</h1>\r\n    </div>\r\n</div>\r\n");
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
