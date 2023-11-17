using Microsoft.AspNetCore.Mvc;

namespace TesterZip.Controllers
{
    public class ExcelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ImportExcelFile()
        {
            return View();
        }
    }
}
