#pragma checksum "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\listProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11121c0b48456953cf370bb3bc575c1cb501986c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_listProduct), @"mvc.1.0.view", @"/Views/Home/listProduct.cshtml")]
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
#line 1 "E:\mwg\bai3_locsp\bai3\bai3\Views\_ViewImports.cshtml"
using bai3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\mwg\bai3_locsp\bai3\bai3\Views\_ViewImports.cshtml"
using bai3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11121c0b48456953cf370bb3bc575c1cb501986c", @"/Views/Home/listProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9bb87af74b4f5bc930422a581e7654a12f48c97", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_listProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<bai3.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\listProduct.cshtml"
 for (int i = 0; i < @Model.Count; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"others-toy-item\">\r\n    <img src=\"https://cdn.tgdd.vn/Products/Images/2427/230494/ta-dan-moony-natural-size-m-46-mieng-cho-be-6-11kg-160622-053020-600x600.jpg\" />\r\n</div>");
#nullable restore
#line 7 "E:\mwg\bai3_locsp\bai3\bai3\Views\Home\listProduct.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<bai3.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591