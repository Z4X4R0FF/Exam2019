#pragma checksum "C:\Users\1\Desktop\Semestr4\Exam2019\ExamRestaurantApp\ExamRestaurantApp\Views\Home\SeeBin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b79fd2ee6e88d4b5f349fab02f72e4519db3920"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SeeBin), @"mvc.1.0.view", @"/Views/Home/SeeBin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SeeBin.cshtml", typeof(AspNetCore.Views_Home_SeeBin))]
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
#line 1 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamRestaurantApp\ExamRestaurantApp\Views\_ViewImports.cshtml"
using ExamRestaurantApp;

#line default
#line hidden
#line 2 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamRestaurantApp\ExamRestaurantApp\Views\_ViewImports.cshtml"
using ExamRestaurantApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b79fd2ee6e88d4b5f349fab02f72e4519db3920", @"/Views/Home/SeeBin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbcb171aee640ca2b86306950867afca9491a1fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SeeBin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ExamRestaurantApp.Models.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamRestaurantApp\ExamRestaurantApp\Views\Home\SeeBin.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            DefineSection("nav", async() => {
            }
            );
            BeginContext(96, 77, true);
            WriteLiteral("    <div class=\"centerWindow\">\r\n        <p>Let\'s make a delivery order!</p>\r\n");
            EndContext();
#line 9 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamRestaurantApp\ExamRestaurantApp\Views\Home\SeeBin.cshtml"
         foreach(var order in Model)
        {

#line default
#line hidden
            BeginContext(222, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(238, 15, false);
#line 11 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamRestaurantApp\ExamRestaurantApp\Views\Home\SeeBin.cshtml"
          Write(order.Food.Name);

#line default
#line hidden
            EndContext();
            BeginContext(253, 21, true);
            WriteLiteral("</p>\r\n            <p>");
            EndContext();
            BeginContext(275, 15, false);
#line 12 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamRestaurantApp\ExamRestaurantApp\Views\Home\SeeBin.cshtml"
          Write(order.Food.Cost);

#line default
#line hidden
            EndContext();
            BeginContext(290, 50, true);
            WriteLiteral("</p>\r\n            <p><button class=\"bubbly-button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 340, "\"", 424, 5);
            WriteAttributeValue("", 350, "location.href", 350, 13, true);
            WriteAttributeValue(" ", 363, "=", 364, 2, true);
            WriteAttributeValue(" ", 365, "\'", 366, 2, true);
#line 13 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamRestaurantApp\ExamRestaurantApp\Views\Home\SeeBin.cshtml"
WriteAttributeValue("", 367, Url.Action("RemoveFromBin", "Home", new {id=order.Id }), 367, 56, false);

#line default
#line hidden
            WriteAttributeValue("", 423, "\'", 423, 1, true);
            EndWriteAttribute();
            BeginContext(425, 22, true);
            WriteLiteral(">Delete</button></p>\r\n");
            EndContext();
#line 14 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamRestaurantApp\ExamRestaurantApp\Views\Home\SeeBin.cshtml"
        }

#line default
#line hidden
            BeginContext(458, 40, true);
            WriteLiteral("        <p><button class=\"bubbly-button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 498, "\"", 558, 5);
            WriteAttributeValue("", 508, "location.href", 508, 13, true);
            WriteAttributeValue(" ", 521, "=", 522, 2, true);
            WriteAttributeValue(" ", 523, "\'", 524, 2, true);
#line 15 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamRestaurantApp\ExamRestaurantApp\Views\Home\SeeBin.cshtml"
WriteAttributeValue("", 525, Url.Action("MakeOrder", "Home"), 525, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 557, "\'", 557, 1, true);
            EndWriteAttribute();
            BeginContext(559, 40, true);
            WriteLiteral(">Make Order</button></p>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ExamRestaurantApp.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
