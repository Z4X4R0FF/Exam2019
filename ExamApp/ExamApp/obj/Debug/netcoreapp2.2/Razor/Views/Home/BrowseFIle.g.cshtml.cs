#pragma checksum "C:\Users\1\Desktop\Semestr4\Exam2019\ExamApp\ExamApp\Views\Home\BrowseFIle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f340be0e4122e8b09c46d27a242443581d55762"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BrowseFIle), @"mvc.1.0.view", @"/Views/Home/BrowseFIle.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/BrowseFIle.cshtml", typeof(AspNetCore.Views_Home_BrowseFIle))]
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
#line 1 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamApp\ExamApp\Views\_ViewImports.cshtml"
using ExamApp;

#line default
#line hidden
#line 2 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamApp\ExamApp\Views\_ViewImports.cshtml"
using ExamApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f340be0e4122e8b09c46d27a242443581d55762", @"/Views/Home/BrowseFIle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cc381882eeb32e8d2e90d7f36eb84b506bb0834", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BrowseFIle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExamApp.Models.UploadedFile>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamApp\ExamApp\Views\Home\BrowseFIle.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(68, 39, true);
            WriteLiteral("<h2>Browse Files</h2>\r\n<p>Name</p>\r\n<p>");
            EndContext();
            BeginContext(108, 10, false);
#line 7 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamApp\ExamApp\Views\Home\BrowseFIle.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(118, 35, true);
            WriteLiteral("</p><br />\r\n<p>Description</p>\r\n<p>");
            EndContext();
            BeginContext(154, 17, false);
#line 9 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamApp\ExamApp\Views\Home\BrowseFIle.cshtml"
Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(171, 28, true);
            WriteLiteral("</p><br />\r\n<p>Text</p>\r\n<p>");
            EndContext();
            BeginContext(200, 10, false);
#line 11 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamApp\ExamApp\Views\Home\BrowseFIle.cshtml"
Write(Model.Text);

#line default
#line hidden
            EndContext();
            BeginContext(210, 39, true);
            WriteLiteral("</p><br />\r\n<p>Total downloads</p>\r\n<p>");
            EndContext();
            BeginContext(250, 23, false);
#line 13 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamApp\ExamApp\Views\Home\BrowseFIle.cshtml"
Write(Model.AmountOfDownloads);

#line default
#line hidden
            EndContext();
            BeginContext(273, 10, true);
            WriteLiteral("</p>\r\n\r\n\r\n");
            EndContext();
#line 16 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamApp\ExamApp\Views\Home\BrowseFIle.cshtml"
 if (Model.hasPass)
{
    

#line default
#line hidden
#line 18 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamApp\ExamApp\Views\Home\BrowseFIle.cshtml"
     using (Html.BeginForm("Download", "Home", FormMethod.Get))
    {

#line default
#line hidden
            BeginContext(379, 66, true);
            WriteLiteral("        <p>Password</p>\r\n        <p><input type=\"hidden\" name=\"id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 445, "\"", 462, 1);
#line 21 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamApp\ExamApp\Views\Home\BrowseFIle.cshtml"
WriteAttributeValue("", 453, Model.Id, 453, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(463, 142, true);
            WriteLiteral(" /></p>\r\n        <p><input type=\"text\" name=\"password\" /></p>\r\n        <p><input type=\"submit\" class=\"bubbly-button\" value=\"Download\" /></p>\r\n");
            EndContext();
#line 24 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamApp\ExamApp\Views\Home\BrowseFIle.cshtml"
    }

#line default
#line hidden
#line 24 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamApp\ExamApp\Views\Home\BrowseFIle.cshtml"
     
}
else
{

#line default
#line hidden
            BeginContext(624, 28, true);
            WriteLiteral("    <p><button type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 652, "\"", 736, 5);
            WriteAttributeValue("", 662, "location.href", 662, 13, true);
            WriteAttributeValue(" ", 675, "=", 676, 2, true);
            WriteAttributeValue(" ", 677, "\'", 678, 2, true);
#line 28 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamApp\ExamApp\Views\Home\BrowseFIle.cshtml"
WriteAttributeValue("", 679, Url.Action("Download", "Home", new {id=Model.Id}, null), 679, 56, false);

#line default
#line hidden
            WriteAttributeValue("", 735, "\'", 735, 1, true);
            EndWriteAttribute();
            BeginContext(737, 24, true);
            WriteLiteral(">Download</button></p>\r\n");
            EndContext();
#line 29 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamApp\ExamApp\Views\Home\BrowseFIle.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExamApp.Models.UploadedFile> Html { get; private set; }
    }
}
#pragma warning restore 1591
