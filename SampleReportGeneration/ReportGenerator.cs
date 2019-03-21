using IronPdf;
using LoremNET;
using System.Text;

namespace SampleReportGeneration
{
    public class ReportGenerator
    {
        public PdfDocument Generate() {
            var renderer = new HtmlToPdf();
            return renderer.RenderHtmlAsPdf(GetHtml());
        }

        private string GetHtml() {
            var sb = new StringBuilder();
            sb.AppendLine("<html>");
            for(var i = 0; i < 100; i++) {
                sb.AppendLine("<p>");
                sb.AppendLine(Lorem.Paragraph(10, 10));
                sb.AppendLine("</p>");
            }
            sb.AppendLine("</html>");
            return sb.ToString();
        }
    }
}
