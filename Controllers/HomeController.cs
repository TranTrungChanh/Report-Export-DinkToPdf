using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Reporting.Interface;
using Reporting.Models;

namespace Reporting.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IEmployee _employee { get; set; }

        private readonly IPdfConverter _pdfConverter;

        public HomeController(
            ILogger<HomeController> logger,
            IEmployee employee,
            IPdfConverter pdfConverter)
        {
            _logger = logger;
            _employee = employee;
            _pdfConverter = pdfConverter;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Pdf()
        {
            var result = _employee.GetEmployees();

            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> ExportPdf(int id)
        {
            var model = _employee.GetEployeeById(id);
            PdfResultDto result = new PdfResultDto();
            result.ByteArray = await _pdfConverter.Convert("Home/__PdfRender", model);
            result.FileName = $"Employee-{model.Id}.pdf";

            return Json(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
