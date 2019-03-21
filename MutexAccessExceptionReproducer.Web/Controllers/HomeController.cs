using SampleReportGeneration;
using System.Web.Mvc;

namespace MutexAccessExceptionReproducer.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() {
            return View();
        }

        public FileStreamResult GenerateReport() {
            IronPdf.License.LicenseKey = "VALID_LICENSE_KEY";
            var generator = new ReportGenerator();
            var result = generator.Generate();
            return new FileStreamResult(result.Stream, "application/pdf");
        }

    }
}