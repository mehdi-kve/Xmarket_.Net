using Microsoft.AspNetCore.Mvc;

namespace webApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}