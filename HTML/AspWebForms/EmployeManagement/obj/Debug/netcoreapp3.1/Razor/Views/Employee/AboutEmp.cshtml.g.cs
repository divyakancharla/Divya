#pragma checksum "E:\Divya\HTML\AspWebForms\EmployeManagement\Views\Employee\AboutEmp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b31bd231f934c578cb0d24c31498765d5dad697b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_AboutEmp), @"mvc.1.0.view", @"/Views/Employee/AboutEmp.cshtml")]
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
#line 1 "E:\Divya\HTML\AspWebForms\EmployeManagement\Views\_ViewImports.cshtml"
using EmployeManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b31bd231f934c578cb0d24c31498765d5dad697b", @"/Views/Employee/AboutEmp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19f86fa316d81af6aa06e8cacb88fc50fb2e6600", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_AboutEmp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeManagement.Models.EmployeProjViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"    <table border=""1"">
        <tr>
            <td>
                ID:
            </td>
            <td>
                Name:
            </td>
            <td>
                Email:
            </td>
            <td>
                Dept:
            </td>
        </tr>

        <tr>
            <td>");
#nullable restore
#line 31 "E:\Divya\HTML\AspWebForms\EmployeManagement\Views\Employee\AboutEmp.cshtml"
           Write(Model.employee.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 32 "E:\Divya\HTML\AspWebForms\EmployeManagement\Views\Employee\AboutEmp.cshtml"
           Write(Model.employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 33 "E:\Divya\HTML\AspWebForms\EmployeManagement\Views\Employee\AboutEmp.cshtml"
           Write(Model.employee.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 34 "E:\Divya\HTML\AspWebForms\EmployeManagement\Views\Employee\AboutEmp.cshtml"
           Write(Model.employee.dept);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td> \r\n            <td>");
#nullable restore
#line 35 "E:\Divya\HTML\AspWebForms\EmployeManagement\Views\Employee\AboutEmp.cshtml"
           Write(Model.projectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n\r\n\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeManagement.Models.EmployeProjViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
