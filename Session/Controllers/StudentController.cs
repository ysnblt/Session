using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Session.Models;

namespace Session.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            // home controllerda tarayıcıya kayıt edilen bilgiyi okuyor.
            var s = JsonConvert.DeserializeObject<Student>(HttpContext.Session.GetString("User"));
            return View(s);
        }
    }
}
