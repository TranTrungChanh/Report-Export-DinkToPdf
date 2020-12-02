#pragma checksum "D:\Demo\Demo Print\Report-Export-DinkToPdf\v5.0\WebClientPrint5-Sample\WCPMVCCS\Views\DemoPrintFileXLS\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f94b9e819a6c5f7db31ae0de6e2961b03b1a8834"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.v5_0_WebClientPrint5_Sample_WCPMVCCS_Views_DemoPrintFileXLS_Index), @"mvc.1.0.view", @"/v5.0/WebClientPrint5-Sample/WCPMVCCS/Views/DemoPrintFileXLS/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f94b9e819a6c5f7db31ae0de6e2961b03b1a8834", @"/v5.0/WebClientPrint5-Sample/WCPMVCCS/Views/DemoPrintFileXLS/Index.cshtml")]
    public class v5_0_WebClientPrint5_Sample_WCPMVCCS_Views_DemoPrintFileXLS_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Demo\Demo Print\Report-Export-DinkToPdf\v5.0\WebClientPrint5-Sample\WCPMVCCS\Views\DemoPrintFileXLS\Index.cshtml"
  
    ViewBag.Title = "Advanced XLS Printing";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">

        <div class=""col-md-12"">
            <h3><a href=""/home/samples"" class=""btn btn-md btn-danger""><i class=""fa fa-chevron-left""></i></a>&nbsp;Advanced DOC Printing</h3>
            <p>
                With <strong>WebClientPrint for ASP.NET</strong> solution you can <strong>print XLS files</strong> right to any installed printer at the client side with advanced settings.
            </p>
            <div class=""alert alert-info"">
                <strong>Requirements:</strong>
                <ul>
                    <li>Available for <strong>Windows clients only</strong></li>
                    <li><strong>Microsoft Excel 97+</strong> must be installed at the client machine</li>
                    <li>XLS files can be any of these file formats: <strong>*.xl, *.xlsx, *.xlsm, *.xlsb, *.xlam, *.xltx, *.xltm, *.xls, *.xla, *.xlt, *.xlm, *.xlw and *.ods</strong></li>
                </ul>
            </div>

            <div class=""form-group ");
            WriteLiteral(@"well"">
                <h4>Click on <strong>""Get Printers Info""</strong> button to get installed Printers</h4>
                <div class=""row"">

                    <div class=""col-md-3"">
                        <a onclick=""javascript:jsWebClientPrint.getPrinters(); $('#spinner').css('visibility', 'visible');"" class=""btn btn-success"">Get Printers...</a>
                    </div>
                    <div class=""col-md-9"">
                        <h3 id=""spinner"" style=""visibility: hidden""><span class=""label label-info""><span class=""glyphicon glyphicon-refresh glyphicon-refresh-animate""></span>Please wait a few seconds...</span></h3>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col-md-4"">
                        <label for=""lstPrinters"">Printers:</label>
                        <select name=""lstPrinters"" id=""lstPrinters"" class=""form-control""></select>
                    </div>
                    <div class=""col-md-4"">
");
            WriteLiteral(@"                        <label for=""txtPagesFrom"">Pages From:</label>
                        <input type=""text"" class=""form-control"" id=""txtPagesFrom"">
                    </div>
                    <div class=""col-md-4"">
                        <label for=""txtPagesTo"">Pages To:</label>
                        <input type=""text"" class=""form-control"" id=""txtPagesTo"">

                    </div>

                </div>
                <hr />
                <div class=""row"">

                    <div class=""col-md-12"">
                        <a class=""btn btn-success btn-lg pull-right"" onclick=""javascript:jsWebClientPrint.print('printerName=' + encodeURIComponent($('#lstPrinters').val()) + '&pagesFrom=' + encodeURIComponent($('#txtPagesFrom').val()) + '&pagesTo=' + encodeURIComponent($('#txtPagesTo').val()));""><strong>Print XLS...</strong></a>
                    </div>
                </div>
                <hr />
                <h4>XLS File Sample Preview - <strong>13 Pages!!!</strong></h");
            WriteLiteral(@"4>
                <iframe id=""ifPreview"" style=""width: 100%; height: 500px;"" frameborder=""0"" src=""//docs.google.com/gview?url=http://webclientprint.azurewebsites.net/files/Project-Scheduling-Monitoring-Tool.xls&embedded=true""></iframe>

            </div>

        </div>


    </div>
</div>



<script type=""text/javascript"">
        //var wcppGetPrintersDelay_ms = 0;
        var wcppGetPrintersTimeout_ms = 60000; //60 sec
        var wcppGetPrintersTimeoutStep_ms = 500; //0.5 sec
        function wcpGetPrintersOnSuccess() {
            $('#spinner').css('visibility', 'hidden');
            // Display client installed printers
            if (arguments[0].length > 0) {
                var p = arguments[0].split(""|"");
                var options = '';
                for (var i = 0; i < p.length; i++) {
                    options += '<option>' + p[i] + '</option>';
                }
                $('#lstPrinters').html(options);
                $('#lstPrinters').focus();
        ");
            WriteLiteral(@"    } else {
                alert(""No printers are installed in your system."");
            }
        }
        function wcpGetPrintersOnFailure() {
            $('#spinner').css('visibility', 'hidden');
            // Do something if printers cannot be got from the client
            alert(""No printers are installed in your system."");
        }
</script>


");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral("\r\n    ");
#nullable restore
#line 103 "D:\Demo\Demo Print\Report-Export-DinkToPdf\v5.0\WebClientPrint5-Sample\WCPMVCCS\Views\DemoPrintFileXLS\Index.cshtml"
Write(Html.Raw(ViewBag.WCPScript));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591