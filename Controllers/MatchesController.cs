using Microsoft.AspNetCore.Mvc;

namespace CSGSIWebClientDemo.Controllers
{
    public class MatchesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Match(int id)
        {
            return View();
        }
    }
}
