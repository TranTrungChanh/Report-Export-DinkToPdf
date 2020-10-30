using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Reporting.Interface
{
    public class PdfConverterAppService : IPdfConverter
    {
        private IConverter _converter { get; set; }

        private IServiceProvider _serviceProvider { get; set; }

        private IRazorViewEngine _viewEngine { get; set; }

        private ITempDataProvider _tempDataProvider { get; set; }

        public PdfConverterAppService(
            IConverter converter,
            IServiceProvider serviceProvider,
            IRazorViewEngine viewEngine,
            ITempDataProvider tempDataProvider)
        {
            _converter = converter;
            _serviceProvider = serviceProvider;
            _viewEngine = viewEngine;
            _tempDataProvider = tempDataProvider;
        }

        public async Task<byte[]> Convert<TModel>(string viewPath, TModel model)
        {
            var html = await RenderViewToString(viewPath, model);

            var random = new Random();

            var globalSettings = new GlobalSettings()
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings() { Top = 18, Bottom = 18, Left = 10, Right = 8 },
                DocumentTitle = "PDF Report"
            };

            List<string> itemLink = new List<string>();
            itemLink.Add(Directory.GetCurrentDirectory());
            itemLink.Add("wwwroot");
            itemLink.Add("css");
            itemLink.Add("Employee");
            itemLink.Add("pdf.css");

            var linkCss = Path.Combine(itemLink.ToArray());
            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = html,
                WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = linkCss },
                FooterSettings = { FontSize = 10, Left = "PDF demo from PAP-Technology", Right = "Trang [page] trong [toPage]", Line = true },
            };

            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

            byte[] result = _converter.Convert(doc);

            return result;
        }

        private async Task<string> RenderViewToString<TModel>(string viewPath, TModel model)
        {
            string result = string.Empty;
            var actionContext = GetActionContext();

            using (var stringWrite = new StringWriter())
            {
                var viewResult = _viewEngine.FindView(actionContext, viewPath, false);

                if (viewResult.View == null)
                {
                    result = "Không tìm thấy định dạng cho trang PDF";
                    throw new NotImplementedException(result);
                }

                var viewDictionary = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary())
                {
                    Model = model
                };

                var viewContext = new ViewContext(
                        actionContext,
                        viewResult.View,
                        viewDictionary,
                        new TempDataDictionary(actionContext.HttpContext, _tempDataProvider),
                        stringWrite,
                        new HtmlHelperOptions()
                    );

                await viewResult.View.RenderAsync(viewContext);

                return stringWrite.ToString();
            }
        }

        private ActionContext GetActionContext()
        {
            var httpContext = new DefaultHttpContext
            {
                RequestServices = _serviceProvider
            };
            return new ActionContext(httpContext, new RouteData(), new ActionDescriptor());
        }
    }
}
