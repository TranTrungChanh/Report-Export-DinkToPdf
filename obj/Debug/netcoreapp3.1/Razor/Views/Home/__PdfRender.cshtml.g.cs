#pragma checksum "D:\ExportPdf\Report-Export-DinkToPdf\Views\Home\__PdfRender.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61fc935f088e6bb2a7dbc36e7a0610b93f905b31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home___PdfRender), @"mvc.1.0.view", @"/Views/Home/__PdfRender.cshtml")]
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
#line 1 "D:\ExportPdf\Report-Export-DinkToPdf\Views\_ViewImports.cshtml"
using Reporting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\ExportPdf\Report-Export-DinkToPdf\Views\Home\__PdfRender.cshtml"
using Reporting.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61fc935f088e6bb2a7dbc36e7a0610b93f905b31", @"/Views/Home/__PdfRender.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c5bca831c3dd22bb2adc499f0d91da3e9ef24e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home___PdfRender : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div id=\"info-employee\">\r\n        <p><span>Họ và tên: </span>");
#nullable restore
#line 5 "D:\ExportPdf\Report-Export-DinkToPdf\Views\Home\__PdfRender.cshtml"
                              Write(Html.Raw($"{Model.FirstName} {Model.LastName}"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n        <p><span>Tuổi: </span>");
#nullable restore
#line 6 "D:\ExportPdf\Report-Export-DinkToPdf\Views\Home\__PdfRender.cshtml"
                         Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n        <p><span>Giới tính: </span>");
#nullable restore
#line 7 "D:\ExportPdf\Report-Export-DinkToPdf\Views\Home\__PdfRender.cshtml"
                              Write(Html.Raw(Model.Gender == true ? "Nam" : "Nữ"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n        <p><span>Địa chỉ: </span>");
#nullable restore
#line 8 "D:\ExportPdf\Report-Export-DinkToPdf\Views\Home\__PdfRender.cshtml"
                            Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591