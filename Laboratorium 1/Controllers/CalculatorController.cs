using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_1.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Result(string op, double? a, double? b)
        {
            if (a is null || b is null)
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
            switch (op)
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
        public IActionResult Form()
        {
            return View();
        }
    }
}
