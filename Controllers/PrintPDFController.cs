using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Neodynamic.SDK.Web;
using Microsoft.AspNetCore.Authorization;

namespace Reporting.Controllers
{
    public class PrintPDFController : Controller
    {
        private readonly IHostingEnvironment _hostEnvironment;

        public PrintPDFController(IHostingEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            ViewData["WCPScript"] = Neodynamic.SDK.Web.WebClientPrint.CreateScript(Url.Action("ProcessRequest", "WebClientPrintAPI", null, Url.ActionContext.HttpContext.Request.Scheme), Url.Action("PrintFile", "PrintPDF", null, Url.ActionContext.HttpContext.Request.Scheme), Url.ActionContext.HttpContext.Session.Id);

            return View();
        }

        [AllowAnonymous]
        public IActionResult PrintFile(string useDefaultPrinter, string printerName)
        {
            try
            {
                //full path of the PDF file to be printed
                string pdfFilePath = @"C:\Users\chanh\Downloads\Quote-13 (3).pdf";

                //create a temp file name for our PDF file...
                string fileName = "MyFile-" + Guid.NewGuid().ToString("N");

                //Create a PrintFilePDF object with the PDF file
                PrintFilePDF file = new PrintFilePDF(pdfFilePath, fileName);
                //Create a ClientPrintJob and send it back to the client!
                ClientPrintJob cpj = new ClientPrintJob();
                //set file to print...
                cpj.PrintFile = file;

                //set client printer...
                //if (useDefaultPrinter == "checked" || printerName == "null")
                //    cpj.ClientPrinter = new DefaultPrinter();
                //else
                    cpj.ClientPrinter = new InstalledPrinter("HP LaserJet Professional M1212nf MFP");

                return File(cpj.GetContent(), "application/octet-stream");
            }
            catch(Exception ex)
            {
                return Ok();
            }
        }
    }
}