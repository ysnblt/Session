using Microsoft.AspNetCore.Mvc;
using Session.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Session.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //tarayıcıya ekliyor
            var s = new Student() /*{Id = 1 , Name = "Yasin" , Email = "ysnblt.gmail.com" }*/;
            s.Name = "Yasin";
            s.Id = 1;
            s.Email = "ysnblt.gmail.com";
            // serialize c# değerini json'a çevirir
            HttpContext.Session.SetString("User", JsonConvert.SerializeObject(s));
            return View(s);
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
    }
}