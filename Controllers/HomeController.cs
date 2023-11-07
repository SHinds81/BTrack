using BTrack.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BTrack.Controllers
{
    public class HomeController : Controller
    {

        public string testString2 = "TestString2";

        private readonly ILogger<HomeController> _logger;

        string testString = "Teststring";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            ViewData["TestDisplay"] = testString;
            ViewData["TestDisplay2"] = testString2;

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
    }
}