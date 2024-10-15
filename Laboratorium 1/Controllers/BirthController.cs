using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_1.Controllers
{
    public class BirthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Form()
        {
            return View();
        }
    }
}
