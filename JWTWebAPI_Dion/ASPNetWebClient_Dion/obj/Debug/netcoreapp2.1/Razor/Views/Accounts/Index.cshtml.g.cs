#pragma checksum "D:\Github\JWT_WebAPI_Dion\JWTWebAPI_Dion\ASPNetWebClient_Dion\Views\Accounts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0547c34096cee00cd8f92d140a4e8ae29ecd20ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Index), @"mvc.1.0.view", @"/Views/Accounts/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Accounts/Index.cshtml", typeof(AspNetCore.Views_Accounts_Index))]
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
#line 1 "D:\Github\JWT_WebAPI_Dion\JWTWebAPI_Dion\ASPNetWebClient_Dion\Views\_ViewImports.cshtml"
using ASPNetWebClient_Dion;

#line default
#line hidden
#line 2 "D:\Github\JWT_WebAPI_Dion\JWTWebAPI_Dion\ASPNetWebClient_Dion\Views\_ViewImports.cshtml"
using ASPNetWebClient_Dion.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0547c34096cee00cd8f92d140a4e8ae29ecd20ff", @"/Views/Accounts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e48b026069fe6deebcad4845d9ea6e675802c501", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Script/Login.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Github\JWT_WebAPI_Dion\JWTWebAPI_Dion\ASPNetWebClient_Dion\Views\Accounts\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Layout/Layout.cshtml";

#line default
#line hidden
            BeginContext(89, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2374, 280, true);
            WriteLiteral(@"
<input id=""Email"" class=""input100"" type=""text"" placeholder=""Email"">
<span class=""focus-input100-1""></span>

<input id=""Password"" type=""password"" placeholder=""Password"">
<span class=""focus-input100-1""></span>

<button id=""buttonLogin"" onclick=""Login()"">Sign in</button>

");
            EndContext();
            DefineSection("script", async() => {
                BeginContext(2670, 1205, true);
                WriteLiteral(@"
    <!--===============================================================================================-->
    <!--<script src=""~/Login_v1/vendor/jquery/jquery-3.2.1.min.js""></script>-->
    <!--===============================================================================================-->
    <!--<script src=""~/Login_v1/vendor/bootstrap/js/popper.js""></script>
    <script src=""~/Login_v1/vendor/bootstrap/js/bootstrap.min.js""></script>-->
    <!--===============================================================================================-->
    <!--<script src=""~/Login_v1/vendor/select2/select2.min.js""></script>-->
    <!--===============================================================================================-->
    <!--<script src=""~/Login_v1/vendor/tilt/tilt.jquery.min.js""></script>
    <script>
        $('.js-tilt').tilt({
            scale: 1.1
        })
    </script>-->
    <!--SweetAlert-->
    <!--<script src=""~/Script/sweetalert2@10..js""></script>-->
    <!--==========");
                WriteLiteral("=====================================================================================-->\r\n    <!--<script src=\"~/Login_v1/js/main.js\"></script>-->\r\n    <!-- Login Function -->\r\n    ");
                EndContext();
                BeginContext(3875, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee92346b93794a6ca16a199794584254", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3916, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(3921, 2, true);
            WriteLiteral("\r\n");
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
