#pragma checksum "C:\Users\1\Desktop\Semestr4\Exam2019\ExamApp\ExamApp\Views\Home\BrowseFIles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f32467d76a310c1b32f0bdd589aaa96bbfdb3b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BrowseFIles), @"mvc.1.0.view", @"/Views/Home/BrowseFIles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/BrowseFIles.cshtml", typeof(AspNetCore.Views_Home_BrowseFIles))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f32467d76a310c1b32f0bdd589aaa96bbfdb3b4", @"/Views/Home/BrowseFIles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cc381882eeb32e8d2e90d7f36eb84b506bb0834", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BrowseFIles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ExamApp.Models.UploadedFile>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(163, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamApp\ExamApp\Views\Home\BrowseFIles.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(197, 57, true);
            WriteLiteral("<p><button onclick=\"sortList()\">SortByName</button></p>\r\n");
            EndContext();
#line 9 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamApp\ExamApp\Views\Home\BrowseFIles.cshtml"
 if (Model.Count != 0)
{
    foreach (var file in Model)
    {

#line default
#line hidden
            BeginContext(321, 32, true);
            WriteLiteral("        <p>Name</p>\r\n        <p>");
            EndContext();
            BeginContext(354, 9, false);
#line 14 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamApp\ExamApp\Views\Home\BrowseFIles.cshtml"
      Write(file.Name);

#line default
#line hidden
            EndContext();
            BeginContext(363, 45, true);
            WriteLiteral("</p>\r\n        <p>Description</p>\r\n        <p>");
            EndContext();
            BeginContext(409, 16, false);
#line 16 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamApp\ExamApp\Views\Home\BrowseFIles.cshtml"
      Write(file.Description);

#line default
#line hidden
            EndContext();
            BeginContext(425, 38, true);
            WriteLiteral("</p>\r\n        <p><button type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 463, "\"", 548, 5);
            WriteAttributeValue("", 473, "location.href", 473, 13, true);
            WriteAttributeValue(" ", 486, "=", 487, 2, true);
            WriteAttributeValue(" ", 488, "\'", 489, 2, true);
#line 17 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamApp\ExamApp\Views\Home\BrowseFIles.cshtml"
WriteAttributeValue("", 490, Url.Action("BrowseFile", "Home", new {id=file.Id}, null), 490, 57, false);

#line default
#line hidden
            WriteAttributeValue("", 547, "\'", 547, 1, true);
            EndWriteAttribute();
            BeginContext(549, 42, true);
            WriteLiteral(">View</button></p>\r\n        <br /><br />\r\n");
            EndContext();
#line 19 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamApp\ExamApp\Views\Home\BrowseFIles.cshtml"
    }
}
else
{

#line default
#line hidden
            BeginContext(610, 31, true);
            WriteLiteral("    <p>Nothing was found.</p>\r\n");
            EndContext();
#line 24 "C:\Users\1\Desktop\Semestr4\Exam2019\ExamApp\ExamApp\Views\Home\BrowseFIles.cshtml"
}

#line default
#line hidden
            BeginContext(644, 1095, true);
            WriteLiteral(@"
<script>
function sortList() {
  var list, i, switching, b, shouldSwitch;
  list = document.getElementById(""id01"");
  switching = true;
  /* Make a loop that will continue until
  no switching has been done: */
  while (switching) {
    // start by saying: no switching is done:
    switching = false;
    b = list.getElementsByTagName(""LI"");
    // Loop through all list-items:
    for (i = 0; i < (b.length - 1); i++) {
      // start by saying there should be no switching:
      shouldSwitch = false;
      /* check if the next item should
      switch place with the current item: */
      if (b[i].innerHTML.toLowerCase() > b[i + 1].innerHTML.toLowerCase()) {
        /* if next item is alphabetically
        lower than current item, mark as a switch
        and break the loop: */
        shouldSwitch = true;
        break;
      }
    }
    if (shouldSwitch) {
      /* If a switch has been marked, make the switch
      and mark the switch as done: */
      b[i].parentNode.insertBef");
            WriteLiteral("ore(b[i + 1], b[i]);\r\n      switching = true;\r\n    }\r\n  }\r\n}\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ExamApp.Models.UploadedFile>> Html { get; private set; }
    }
}
#pragma warning restore 1591
