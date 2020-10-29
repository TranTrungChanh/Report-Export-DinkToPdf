using Microsoft.AspNetCore.Mvc;

namespace Reporting.Models
{
    public class PdfParameterDto
    {
        public string ViewPath { get; set; }
        public ControllerContext Context { get; set; }
        //public object Model { get; set; }
    }
}
