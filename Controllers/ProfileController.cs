﻿using Microsoft.AspNetCore.Mvc;

namespace CSGSIWebClientDemo.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
