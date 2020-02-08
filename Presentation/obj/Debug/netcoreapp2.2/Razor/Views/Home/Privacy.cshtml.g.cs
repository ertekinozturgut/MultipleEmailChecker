#pragma checksum "C:\Users\Ertekin\source\repos\EmailChecker\Presentation\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8134555069e9e9b777a0806c7c3f98138402f70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Privacy.cshtml", typeof(AspNetCore.Views_Home_Privacy))]
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
#line 1 "C:\Users\Ertekin\source\repos\EmailChecker\Presentation\Views\_ViewImports.cshtml"
using Presentation;

#line default
#line hidden
#line 2 "C:\Users\Ertekin\source\repos\EmailChecker\Presentation\Views\_ViewImports.cshtml"
using Presentation.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8134555069e9e9b777a0806c7c3f98138402f70", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aca7828e27a152be4cd8b1f2c1fa15ad084747ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Entities.Emails>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Ertekin\source\repos\EmailChecker\Presentation\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
            BeginContext(82, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(87, 17, false);
#line 6 "C:\Users\Ertekin\source\repos\EmailChecker\Presentation\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(104, 2715, true);
            WriteLiteral(@"</h1>

<p>Use this page to detail your site's privacy policy.</p>
<style>

    body {
        background-color: #F1F4F5;
    }

    .card-header {
        padding: 0.2rem 1.25rem;
        /* margin-bottom: 0; */
        background-color: #ffffff;
        border-bottom: 0px;
    }

    .card-body {
        padding: 0rem 1.25rem;
    }

    p {
        margin-top: 0;
        margin-bottom: 10px;
    }

    .card {
        border-radius: 0px;
        padding-top: 15px;
        padding-bottom: 15px;
    }

    .flex-wrap {
        margin-bottom: -35px;
    }

    div.dataTables_wrapper div.dataTables_paginate {
        margin-top: -25px;
    }

    .page-item.active .page-link {
        z-index: 1;
        color: #fff;
        background-color: #5D78FF;
        border-color: #5D78FF;
    }
</style>



<link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.");
            WriteLiteral(@"1.1/js/bootstrap.min.js""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
<!------ Include the above in your HEAD tag ---------->
<!-- Datatable Dependency start -->
<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/v/bs4/jszip-2.5.0/dt-1.10.20/b-1.6.1/b-colvis-1.6.1/b-html5-1.6.1/b-print-1.6.1/r-2.2.3/datatables.min.css"" />
<script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.36/pdfmake.min.js""></script>
<script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.36/vfs_fonts.js""></script>
<script type=""text/javascript"" src=""https://cdn.datatables.net/v/bs4/jszip-2.5.0/dt-1.10.20/b-1.6.1/b-colvis-1.6.1/b-html5-1.6.1/b-print-1.6.1/r-2.2.3/datatables.min.js""></script>

<!-- Datatable Dependency end -->


<div class=""container"">

    <div class=""col-md-12"">
        <div class=""card"">

            <div class=""card-header"">
                <h4>Data Table Export</h4>
  ");
            WriteLiteral(@"              <p>Data table with print, pdf, csv</p>
            </div>

            <div class=""card-body"">

                <table class=""table table-bordered table-hover"" id=""table_id"">
                    <thead>
                        <tr>
                            <th data-priority=""1"">#</th>
                            <th>E-mail</th>
                            <th>Domain Address</th>
                            <th>Mx Address</th>
                            <th data-priority=""2"">Error Type</th>
                            <th>Error Text</th>

                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 93 "C:\Users\Ertekin\source\repos\EmailChecker\Presentation\Views\Home\Privacy.cshtml"
                          
                            int i = 1;
                            foreach (var a in Model)
                            {

#line default
#line hidden
            BeginContext(2972, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(3051, 1, false);
#line 98 "C:\Users\Ertekin\source\repos\EmailChecker\Presentation\Views\Home\Privacy.cshtml"
                                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3052, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3100, 7, false);
#line 99 "C:\Users\Ertekin\source\repos\EmailChecker\Presentation\Views\Home\Privacy.cshtml"
                                   Write(a.email);

#line default
#line hidden
            EndContext();
            BeginContext(3107, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3155, 13, false);
#line 100 "C:\Users\Ertekin\source\repos\EmailChecker\Presentation\Views\Home\Privacy.cshtml"
                                   Write(a.emailDomain);

#line default
#line hidden
            EndContext();
            BeginContext(3168, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3216, 9, false);
#line 101 "C:\Users\Ertekin\source\repos\EmailChecker\Presentation\Views\Home\Privacy.cshtml"
                                   Write(a.emailMx);

#line default
#line hidden
            EndContext();
            BeginContext(3225, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3273, 13, false);
#line 102 "C:\Users\Ertekin\source\repos\EmailChecker\Presentation\Views\Home\Privacy.cshtml"
                                   Write(a.emailStatus);

#line default
#line hidden
            EndContext();
            BeginContext(3286, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3334, 19, false);
#line 103 "C:\Users\Ertekin\source\repos\EmailChecker\Presentation\Views\Home\Privacy.cshtml"
                                   Write(a.emailStatusDetail);

#line default
#line hidden
            EndContext();
            BeginContext(3353, 46, true);
            WriteLiteral("</td>\r\n                                </tr>\r\n");
            EndContext();
#line 105 "C:\Users\Ertekin\source\repos\EmailChecker\Presentation\Views\Home\Privacy.cshtml"
                                i++;
                            }
                        

#line default
#line hidden
            BeginContext(3495, 490, true);
            WriteLiteral(@"

                    </tbody>
                </table>

            </div>

        </div>
    </div>

</div>

<script>
    $(document).ready(function () {
        $('#table_id').DataTable({

            dom: 'Bfrtip',
            responsive: true,
            pageLength: 25,
            // lengthMenu: [0, 5, 10, 20, 50, 100, 200, 500],

            buttons: [
                'copy', 'csv', 'excel', 'pdf', 'print'
            ]

        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Entities.Emails>> Html { get; private set; }
    }
}
#pragma warning restore 1591