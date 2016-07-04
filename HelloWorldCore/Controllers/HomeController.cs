using Microsoft.AspNetCore.Mvc;

namespace HelloWorldCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
