#pragma checksum "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\Shared\Components\UserComment\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddbb9bd32e028437ffe031b4f03d508f0996bd3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UserComment_Default), @"mvc.1.0.view", @"/Views/Shared/Components/UserComment/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/UserComment/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_UserComment_Default))]
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
#line 1 "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\_ViewImports.cshtml"
using MyBlog.WebUI;

#line default
#line hidden
#line 2 "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\_ViewImports.cshtml"
using MyBlog.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddbb9bd32e028437ffe031b4f03d508f0996bd3f", @"/Views/Shared/Components/UserComment/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b96df1fe9848f97de6cba257787bbb9d8b29c26", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_UserComment_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyBlog.DataAccess.ViewModels.CommentsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\Shared\Components\UserComment\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
            BeginContext(98, 85, true);
            WriteLiteral("<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n        <ul class=\"list-group\">\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\Shared\Components\UserComment\Default.cshtml"
              
                if (Model.CommentDto != null)
                {
                    

#line default
#line hidden
#line 13 "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\Shared\Components\UserComment\Default.cshtml"
                     foreach (var item in Model.Comments)
                    {

#line default
#line hidden
            BeginContext(347, 86, true);
            WriteLiteral("                        <li class=\"list-group-item\">\r\n                            <h3>");
            EndContext();
            BeginContext(434, 25, false);
#line 16 "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\Shared\Components\UserComment\Default.cshtml"
                           Write(item.PostCommentDto.Title);

#line default
#line hidden
            EndContext();
            BeginContext(459, 50, true);
            WriteLiteral("</h3>\r\n                            <p>Yorumunuz : ");
            EndContext();
            BeginContext(510, 12, false);
#line 17 "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\Shared\Components\UserComment\Default.cshtml"
                                      Write(item.Content);

#line default
#line hidden
            EndContext();
            BeginContext(522, 36, true);
            WriteLiteral("</p>\r\n\r\n                            ");
            EndContext();
            BeginContext(558, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddbb9bd32e028437ffe031b4f03d508f0996bd3f6204", async() => {
                BeginContext(657, 3, true);
                WriteLiteral("Sil");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 19 "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\Shared\Components\UserComment\Default.cshtml"
                                                                                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(664, 35, true);
            WriteLiteral("\r\n\r\n                        </li>\r\n");
            EndContext();
#line 22 "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\Shared\Components\UserComment\Default.cshtml"
                    }

#line default
#line hidden
#line 22 "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\Shared\Components\UserComment\Default.cshtml"
                     
                }
                else
                {

#line default
#line hidden
            BeginContext(782, 124, true);
            WriteLiteral("                    <p class=\"alert-danger\" style=\"margin-top:30px;\">Henüz yapmış olduğunuz bir yorum bulunmamaktadır.</p>\r\n");
            EndContext();
#line 27 "C:\Users\Ferdi\Desktop\newproject\MyBlogSite\MyBlog.WebUI\Views\Shared\Components\UserComment\Default.cshtml"
                }
            

#line default
#line hidden
            BeginContext(940, 37, true);
            WriteLiteral("        </ul>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyBlog.DataAccess.ViewModels.CommentsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
