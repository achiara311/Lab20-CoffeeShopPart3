#pragma checksum "C:\Users\achia\OneDrive\Desktop\LabsWeekSix\Lab20CoffeeShopDatabase\Views\Home\ListOfRegisteredUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16c9cde37f560049bda60dd556133f651507edb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListOfRegisteredUsers), @"mvc.1.0.view", @"/Views/Home/ListOfRegisteredUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ListOfRegisteredUsers.cshtml", typeof(AspNetCore.Views_Home_ListOfRegisteredUsers))]
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
#line 1 "C:\Users\achia\OneDrive\Desktop\LabsWeekSix\Lab20CoffeeShopDatabase\Views\_ViewImports.cshtml"
using Lab20CoffeeShopDatabase;

#line default
#line hidden
#line 2 "C:\Users\achia\OneDrive\Desktop\LabsWeekSix\Lab20CoffeeShopDatabase\Views\_ViewImports.cshtml"
using Lab20CoffeeShopDatabase.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16c9cde37f560049bda60dd556133f651507edb8", @"/Views/Home/ListOfRegisteredUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cedc627bb39efbc62015f2e4a0cfcd629c65426", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListOfRegisteredUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lab20CoffeeShopDatabase.Models.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\achia\OneDrive\Desktop\LabsWeekSix\Lab20CoffeeShopDatabase\Views\Home\ListOfRegisteredUsers.cshtml"
  
    ViewData["Title"] = "ListOfRegisteredUsers";

#line default
#line hidden
            BeginContext(59, 26, true);
            WriteLiteral("\r\n<h1>ListOfUsers</h1>\r\n\r\n");
            EndContext();
            BeginContext(142, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 11 "C:\Users\achia\OneDrive\Desktop\LabsWeekSix\Lab20CoffeeShopDatabase\Views\Home\ListOfRegisteredUsers.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(179, 17, true);
            WriteLiteral("    <p>\r\n        ");
            EndContext();
            BeginContext(197, 13, false);
#line 14 "C:\Users\achia\OneDrive\Desktop\LabsWeekSix\Lab20CoffeeShopDatabase\Views\Home\ListOfRegisteredUsers.cshtml"
   Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(210, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(221, 13, false);
#line 15 "C:\Users\achia\OneDrive\Desktop\LabsWeekSix\Lab20CoffeeShopDatabase\Views\Home\ListOfRegisteredUsers.cshtml"
   Write(item.Password);

#line default
#line hidden
            EndContext();
            BeginContext(234, 24, true);
            WriteLiteral("\r\n    </p>\r\n    <br />\r\n");
            EndContext();
#line 18 "C:\Users\achia\OneDrive\Desktop\LabsWeekSix\Lab20CoffeeShopDatabase\Views\Home\ListOfRegisteredUsers.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lab20CoffeeShopDatabase.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
