using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
