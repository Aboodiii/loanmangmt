#pragma checksum "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Customer\MyLoanstwo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e71e7a866408a6f8560cbc9578e934c35655ee49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_MyLoanstwo), @"mvc.1.0.view", @"/Views/Customer/MyLoanstwo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e71e7a866408a6f8560cbc9578e934c35655ee49", @"/Views/Customer/MyLoanstwo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b5dd3ec496b1a6ca3ba26a22fe51978d75a289", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_MyLoanstwo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LoanManagementDone.Models.MultipleClassApplication>>
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
        <h3>Your Loan Applications</h3>
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>Loan Id</th>
                        <th>Loan Control Number</th>
                        <th>Loan Amount</th>
                        <th>Total to be paid</th>
                        <th>Purpose</th>
                        <th>Loan Submission Date</th>
                        <th>Loan Type</th>
                        <th>Loan Status</th>
                        <th>Remarks From Lender</th>

                        <th>Details</th>

                        <th>Delete </th>
                    </tr>
                </thead>
                <tfoot>
            ");
            WriteLiteral(@"        <tr>
                        <th>Loan Id</th>
                        <th>Loan Control Number</th>
                        <th>Loan Amount</th>
                        <th>Total to be paid</th>
                        <th>Purpose</th>
                        <th>Loan Submission Date</th>
                        <th>Loan Type</th>
                        <th>Loan Status</th>
                        <th>Remarks From Lender</th>
                        <th>Details</th>

                        <th>Delete </th>
                    </tr>
                    <tr>
                        <td colspan=""11"">  <a href=""/Customer/LoanCreate"" class=""btn btn-success ""><i class=""bi bi-plus-circle""></i>   Add New Loan Application</a></td>
                    </tr>

                </tfoot>
                <tbody>

");
#nullable restore
#line 55 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Customer\MyLoanstwo.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n\r\n                            <td>");
#nullable restore
#line 59 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Customer\MyLoanstwo.cshtml"
                           Write(item.LoanApplicationsmultipleapp.LoanApplicationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 60 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Customer\MyLoanstwo.cshtml"
                           Write(item.LoanApplicationsmultipleapp.LoanControlNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td>");
#nullable restore
#line 62 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Customer\MyLoanstwo.cshtml"
                           Write(item.LoanApplicationsmultipleapp.LoanAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 63 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Customer\MyLoanstwo.cshtml"
                           Write(item.LoanApplicationsmultipleapp.TotalAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 64 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Customer\MyLoanstwo.cshtml"
                           Write(item.LoanApplicationsmultipleapp.Purpose);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 65 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Customer\MyLoanstwo.cshtml"
                           Write(item.LoanApplicationsmultipleapp.LoanApplicationSubmissionDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                            <td>");
#nullable restore
#line 68 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Customer\MyLoanstwo.cshtml"
                           Write(item.LoanTypesmultipleapp.LoanName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n\r\n                            <td>");
#nullable restore
#line 72 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Customer\MyLoanstwo.cshtml"
                           Write(item.LoanApplicationsmultipleapp.LoanStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 73 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Customer\MyLoanstwo.cshtml"
                           Write(item.LoanApplicationsmultipleapp.Remarks);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2888, "\"", 2971, 2);
            WriteAttributeValue("", 2895, "/Customer/LoanAppDetails/", 2895, 25, true);
#nullable restore
#line 76 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Customer\MyLoanstwo.cshtml"
WriteAttributeValue("", 2920, item.LoanApplicationsmultipleapp.LoanApplicationId, 2920, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-rounded\"><i class=\"bi bi-eye\"></i>Details</a>\r\n                            </td>\r\n\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3149, "\"", 3231, 2);
            WriteAttributeValue("", 3156, "/Customer/LoanAppDelete/", 3156, 24, true);
#nullable restore
#line 80 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Customer\MyLoanstwo.cshtml"
WriteAttributeValue("", 3180, item.LoanApplicationsmultipleapp.LoanApplicationId, 3180, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-rounded\"><i class=\"bi bi-trash\"></i>Delete</a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 83 "C:\Users\Abdellah\Pictures\LoanManagementDone\LoanManagementDone\Views\Customer\MyLoanstwo.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LoanManagementDone.Models.MultipleClassApplication>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
