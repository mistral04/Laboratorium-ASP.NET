using Laboratorium_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Laboratorium_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IActionResult About()
        {
            return View();
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Calculator(string op, double? a, double? b)
        {
            if(a is null || b is null)
            {
                ViewBag.ErrorMessage = "Niepoprawny format liczby w parametrze a lub b";
                return View("CustomError");
            }
            
            if (!(op == "add" || op == "sub" || op == "mul" || op == "div"))
            {
                ViewBag.ErrorMessage = "Niepoprawny format operacji";
                return View("CustomError");
            }
            ViewBag.a = a;
            ViewBag.b = b;
            switch(op)
            {
                case "add":
                    ViewBag.result = a + b;
                    @ViewBag.op = '+';
                    break;
                case "sub":
                    ViewBag.result = a - b;
                    @ViewBag.op = '-';
                    break;
                case "mul":
                    ViewBag.result = a * b;
                    @ViewBag.op = '*';
                    break;
                case "div":
                    ViewBag.result = a / b;
                    @ViewBag.op = '÷';
                    break;

            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
