#pragma checksum "D:\Github\JWT_WebAPI_Dion\JWTWebAPI_Dion\ASPNetWebClient_Dion\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0723a602e84d5a261d35f2702dcc54883c69cad5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ASPNetWebClient_Dion.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage__StatusMessage), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml", typeof(ASPNetWebClient_Dion.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage__StatusMessage))]
namespace ASPNetWebClient_Dion.Areas.Identity.Pages.Account.Manage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Github\JWT_WebAPI_Dion\JWTWebAPI_Dion\ASPNetWebClient_Dion\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\Github\JWT_WebAPI_Dion\JWTWebAPI_Dion\ASPNetWebClient_Dion\Areas\Identity\Pages\_ViewImports.cshtml"
using ASPNetWebClient_Dion.Areas.Identity;

#line default
#line hidden
#line 3 "D:\Github\JWT_WebAPI_Dion\JWTWebAPI_Dion\ASPNetWebClient_Dion\Areas\Identity\Pages\_ViewImports.cshtml"
using ASPNetWebClient_Dion.Areas.Identity.Data;

#line default
#line hidden
#line 1 "D:\Github\JWT_WebAPI_Dion\JWTWebAPI_Dion\ASPNetWebClient_Dion\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using ASPNetWebClient_Dion.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 1 "D:\Github\JWT_WebAPI_Dion\JWTWebAPI_Dion\ASPNetWebClient_Dion\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using ASPNetWebClient_Dion.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0723a602e84d5a261d35f2702dcc54883c69cad5", @"/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79aa0789ce891a62383c8e9f519162cbdcdee24c", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19591d4079b947162df50f158d1f2348c568f319", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef87536fb93549f877e4de7dfccaf34ad4198f66", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Github\JWT_WebAPI_Dion\JWTWebAPI_Dion\ASPNetWebClient_Dion\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
            BeginContext(136, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 144, "\"", 201, 4);
            WriteAttributeValue("", 152, "alert", 152, 5, true);
            WriteAttributeValue(" ", 157, "alert-", 158, 7, true);
#line 6 "D:\Github\JWT_WebAPI_Dion\JWTWebAPI_Dion\ASPNetWebClient_Dion\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
WriteAttributeValue("", 164, statusMessageClass, 164, 19, false);

#line default
#line hidden
            WriteAttributeValue(" ", 183, "alert-dismissible", 184, 18, true);
            EndWriteAttribute();
            BeginContext(202, 158, true);
            WriteLiteral(" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n        ");
            EndContext();
            BeginContext(361, 5, false);
#line 8 "D:\Github\JWT_WebAPI_Dion\JWTWebAPI_Dion\ASPNetWebClient_Dion\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
   Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(366, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 10 "D:\Github\JWT_WebAPI_Dion\JWTWebAPI_Dion\ASPNetWebClient_Dion\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
