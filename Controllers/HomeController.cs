using BTrack.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using BTrack.Data;
using BTrack.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace BTrack.Controllers
{
    public class HomeController : Controller
    {

        public string testString2 = "TestString2";
        string testString = "Teststring";

        private readonly BTrackContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, BTrackContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var bugStatus1Total = _context.Bugs.Count(a => a.bugStatus == 1);
            var bugStatus2Total = _context.Bugs.Count(a => a.bugStatus == 2);
            var bugStatus3Total = _context.Bugs.Count(a => a.bugStatus == 3);
            var bugStatus4Total = _context.Bugs.Count(a => a.bugId == a.bugId);
            

            ViewData["bugStatus1Total"] = bugStatus1Total;
            ViewData["bugStatus2Total"] = bugStatus2Total;
            ViewData["bugStatus3Total"] = bugStatus3Total;
            ViewData["bugStatus4Total"] = bugStatus4Total;


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