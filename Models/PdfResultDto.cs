using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reporting.Models
{
    public class PdfResultDto
    {
        public byte[] ByteArray { get; set; }
        public string FileName { get; set; }
    }
}
