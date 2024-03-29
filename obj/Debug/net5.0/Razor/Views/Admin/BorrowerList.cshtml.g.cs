#pragma checksum "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04b30c1ac4ed370988dfcf862b0c6c4a8d1ce155"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_BorrowerList), @"mvc.1.0.view", @"/Views/Admin/BorrowerList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04b30c1ac4ed370988dfcf862b0c6c4a8d1ce155", @"/Views/Admin/BorrowerList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b5dd3ec496b1a6ca3ba26a22fe51978d75a289", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_BorrowerList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LoanManagementDone.Models.MultipleAdminView>>
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
        <h3>Borrower List</h3>
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>


                        <th>Customer Name</th>
                        <th>Loan Amount</th>
                        <th>Total to be paid</th>

                        <th>Loan Approval Date</th>
                        <th>Payment Date</th>
                        <th>Loan Type</th>

                        <th>Payment Status</th>
                        <th>Details</th>
                        <th>Give Response</th>
                        <th>Delete </th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>


                        <th>Custome");
            WriteLiteral(@"r Name</th>
                        <th>Loan Amount</th>
                        <th>Total to be paid</th>

                        <th>Loan Approval Date</th>
                        <th>Payment Date</th>
                        <th>Loan Type</th>

                        <th>Payment Status</th>
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
#line 58 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerList.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n\r\n\r\n\r\n                            <td>");
#nullable restore
#line 64 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerList.cshtml"
                            Write(item.CustomerAdminview.FirstName + " " + item.CustomerAdminview.MiddleName + " " + item.CustomerAdminview.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 65 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerList.cshtml"
                           Write(item.LoanApplicationAdminView.LoanAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 66 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerList.cshtml"
                           Write(item.LoanApplicationAdminView.TotalAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td>");
#nullable restore
#line 68 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerList.cshtml"
                           Write(item.LoanApplicationAdminView.LoanApplicationApprovedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 69 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerList.cshtml"
                           Write(item.LoanApplicationAdminView.PaymentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                            <td>");
#nullable restore
#line 72 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerList.cshtml"
                           Write(item.LoanTypesAdminView.LoanName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n\r\n                            <td>");
#nullable restore
#line 76 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerList.cshtml"
                           Write(item.LoanApplicationAdminView.PaymentStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2674, "\"", 2752, 2);
            WriteAttributeValue("", 2681, "/Admin/BorrowerDetails/", 2681, 23, true);
#nullable restore
#line 79 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerList.cshtml"
WriteAttributeValue("", 2704, item.LoanApplicationAdminView.LoanApplicationId, 2704, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-rounded\"><i class=\"bi bi-eye\"></i>Details</a>\r\n                            </td>\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2928, "\"", 3004, 2);
            WriteAttributeValue("", 2935, "/Admin/HandlePayment/", 2935, 21, true);
#nullable restore
#line 82 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerList.cshtml"
WriteAttributeValue("", 2956, item.LoanApplicationAdminView.LoanApplicationId, 2956, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-rounded\"><i class=\"bi bi-eye\"></i>Payment </a>\r\n                            </td>\r\n\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3183, "\"", 3260, 2);
            WriteAttributeValue("", 3190, "/Admin/BorrowerDelete/", 3190, 22, true);
#nullable restore
#line 86 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerList.cshtml"
WriteAttributeValue("", 3212, item.LoanApplicationAdminView.LoanApplicationId, 3212, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-rounded\"><i class=\"bi bi-trash\"></i>Delete</a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 89 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerList.cshtml"
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
