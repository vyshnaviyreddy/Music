using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class MusicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
         public IActionResult Pop()
        {
            return View();
        }
        public IActionResult Instrumental()
        {
            return Content("Instrumental Music");
        }
        public IActionResult Rock()
        {
            return Json(new {name="Music", description = "Enjoy the music."});
        }

        public IActionResult Play()
        {
            return Content("<html><body><h1>Music</h1></body></html>", "text/html");
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
