#pragma checksum "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\LoanApplications.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c24fbfb22ab9358a30945c91172f21c3c1fc16b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_LoanApplications), @"mvc.1.0.view", @"/Views/Admin/LoanApplications.cshtml")]
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
#line 1 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\_ViewImports.cshtml"
using LoanManagementDone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\_ViewImports.cshtml"
using LoanManagementDone.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c24fbfb22ab9358a30945c91172f21c3c1fc16b1", @"/Views/Admin/LoanApplications.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b5dd3ec496b1a6ca3ba26a22fe51978d75a289", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_LoanApplications : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LoanManagementDone.Models.MultipleAdminView>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<br />
<br />


<!-- DataTables Example -->
<div class=""card mb-3"">
    <div class=""card-header"">
        <i class=""fas fa-table""></i>
        <h3>Loan Applications</h3>
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>

                        <th>Loan Control Number</th>
                        <th>Customer Name</th>
                        <th>Loan Amount</th>
                        <th>Total to be paid</th>
                        <th>Purpose</th>
                        <th>Loan Submission Date</th>
                        <th>Loan Type</th>

                        <th>Loan Status</th>
                        <th>Details</th>
                        <th>Give Response</th>
                        <th>Delete </th>
                    </tr>
                </thead>
                <tfoot>
                 ");
            WriteLiteral(@"   <tr>

                        <th>Loan Control Number</th>
                        <th>Customer Name</th>
                        <th>Loan Amount</th>
                        <th>Total to be paid</th>
                        <th>Purpose</th>
                        <th>Loan Submission Date</th>
                        <th>Loan Type</th>

                        <th>Loan Status</th>
                        <th>Details</th>
                        <th>Give Response</th>
                        <th>Delete </th>
                    </tr>
                    <tr>
                        <td colspan=""11"">  <a href=""/Customer/LoanCreate"" class=""btn btn-success ""><i class=""bi bi-plus-circle""></i>   Add New Loan Application</a></td>
                    </tr>

                </tfoot>
                <tbody>

");
#nullable restore
#line 56 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\LoanApplications.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n\r\n\r\n                            <td>");
#nullable restore
#line 61 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\LoanApplications.cshtml"
                           Write(item.LoanApplicationAdminView.LoanControlNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 62 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\LoanApplications.cshtml"
                            Write(item.CustomerAdminview.FirstName + " " + item.CustomerAdminview.MiddleName + " " + item.CustomerAdminview.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 63 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\LoanApplications.cshtml"
                           Write(item.LoanApplicationAdminView.LoanAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 64 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\LoanApplications.cshtml"
                           Write(item.LoanApplicationAdminView.TotalAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 65 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\LoanApplications.cshtml"
                           Write(item.LoanApplicationAdminView.Purpose);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 66 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\LoanApplications.cshtml"
                           Write(item.LoanApplicationAdminView.LoanApplicationSubmissionDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                            <td>");
#nullable restore
#line 69 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\LoanApplications.cshtml"
                           Write(item.LoanTypesAdminView.LoanName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n\r\n                            <td>");
#nullable restore
#line 73 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\LoanApplications.cshtml"
                           Write(item.LoanApplicationAdminView.LoanStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2844, "\"", 2921, 2);
            WriteAttributeValue("", 2851, "/Admin/LoanAppDetails/", 2851, 22, true);
#nullable restore
#line 76 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\LoanApplications.cshtml"
WriteAttributeValue("", 2873, item.LoanApplicationAdminView.LoanApplicationId, 2873, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-rounded\"><i class=\"bi bi-eye\"></i>Details</a>\r\n                            </td>\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3100, "\"", 3185, 2);
            WriteAttributeValue("", 3107, "/Admin/HandleLoanApplications/", 3107, 30, true);
#nullable restore
#line 79 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\LoanApplications.cshtml"
WriteAttributeValue("", 3137, item.LoanApplicationAdminView.LoanApplicationId, 3137, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-rounded\"><i class=\"bi bi-eye\"></i>Handle </a>\r\n                            </td>\r\n\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3363, "\"", 3439, 2);
            WriteAttributeValue("", 3370, "/Admin/LoanAppDelete/", 3370, 21, true);
#nullable restore
#line 83 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\LoanApplications.cshtml"
WriteAttributeValue("", 3391, item.LoanApplicationAdminView.LoanApplicationId, 3391, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-rounded\"><i class=\"bi bi-trash\"></i>Delete</a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 86 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\LoanApplications.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </tbody>
            </table>
        </div>
    </div>
</div>

<div class=""card-footer small text-muted"">
    Updated on<div id=""current_date"">


        <script>
            document.getElementById(""current_date"").innerHTML = Date();
        </script>
    </div>

</div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LoanManagementDone.Models.MultipleAdminView>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
