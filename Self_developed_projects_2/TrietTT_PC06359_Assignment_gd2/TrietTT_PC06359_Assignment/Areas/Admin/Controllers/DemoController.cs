using Microsoft.AspNetCore.Mvc;

namespace TrietTT_PC06359_Assignment.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
