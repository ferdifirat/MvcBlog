#pragma checksum "C:\Users\Ferdi\Desktop\MyBlogSite\MyBlog.WebUI\Views\Admin\CategoryDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf345fa7d29bc8db714202e2d662d72fdeae873f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CategoryDetail), @"mvc.1.0.view", @"/Views/Admin/CategoryDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/CategoryDetail.cshtml", typeof(AspNetCore.Views_Admin_CategoryDetail))]
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
#line 1 "C:\Users\Ferdi\Desktop\MyBlogSite\MyBlog.WebUI\Views\_ViewImports.cshtml"
using MyBlog.WebUI;

#line default
#line hidden
#line 2 "C:\Users\Ferdi\Desktop\MyBlogSite\MyBlog.WebUI\Views\_ViewImports.cshtml"
using MyBlog.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf345fa7d29bc8db714202e2d662d72fdeae873f", @"/Views/Admin/CategoryDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b96df1fe9848f97de6cba257787bbb9d8b29c26", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CategoryDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyBlog.DataAccess.ViewModels.CategoryViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Ferdi\Desktop\MyBlogSite\MyBlog.WebUI\Views\Admin\CategoryDetail.cshtml"
  
    ViewData["Title"] = "CategoryDetail";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(157, 29, true);
            WriteLiteral("\r\n<h1>CategoryDetail</h1>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyBlog.DataAccess.ViewModels.CategoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591