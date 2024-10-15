using Laboratorium_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_1.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Result([FromForm] Calculator model)
        {
            if (!model.IsValid())
            {
                return View("Error");
            }
            return View(model);
        }
        public IActionResult Form()
        {
            return View();
        }
        
    }
}
