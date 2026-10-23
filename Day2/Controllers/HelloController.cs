using Microsoft.AspNetCore.Mvc;

namespace Day2.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name = "User", int numTimes = 1)
        {
            ViewData["Message"] = "Hello, " + name;
            ViewBag.NumTimes = numTimes; 

            return View();
        }
    }
}