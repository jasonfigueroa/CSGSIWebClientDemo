﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSGSIWebClient.Data;
using CSGSIWebClient.Models;
using CSGSIWebClient.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CSGSIWebClient.Controllers
{
    public class MatchesController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            if (HttpContext.Request.Query["routedFromLogin"] == "1")
            {
                JWT jwt = new JWT()
                {
                    access_token = HttpContext.User.Claims.Where(c => c.Type == "AccessToken").FirstOrDefault().Value,
                    refresh_token = HttpContext.User.Claims.Where(c => c.Type == "RefreshToken").FirstOrDefault().Value,
                };
                ViewBag.JWT = jwt;
            }

            return View();
        }

        [Authorize]
        public IActionResult Match(int id)
        {
            if (HttpContext.Request.Query["routedFromLogin"] == "1")
            {
                JWT jwt = new JWT()
                {
                    access_token = HttpContext.User.Claims.Where(c => c.Type == "AccessToken").FirstOrDefault().Value,
                    refresh_token = HttpContext.User.Claims.Where(c => c.Type == "RefreshToken").FirstOrDefault().Value,
                };
                ViewBag.JWT = jwt;
            }

            return View();
        }
    }
}
