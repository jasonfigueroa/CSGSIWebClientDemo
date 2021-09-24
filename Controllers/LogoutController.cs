using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSGSIWebClientDemo.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CSGSIWebClientDemo.Controllers
{
    public class LogoutController : Controller
    {        
        public async Task<IActionResult> Index()
        {
            await HttpContext.SignOutAsync();
            return View();
        }
    }
}
