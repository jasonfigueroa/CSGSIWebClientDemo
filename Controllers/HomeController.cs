using Microsoft.AspNetCore.Mvc;

namespace CSGSIWebClientDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
