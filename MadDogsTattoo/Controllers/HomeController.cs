using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using MadDogsTattoo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;

namespace MadDogsTattoo.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult CultureManagement(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, 
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions{Expires = DateTimeOffset.Now.AddDays(30) });

            return RedirectToAction(nameof(Index));
        }
    }
}
