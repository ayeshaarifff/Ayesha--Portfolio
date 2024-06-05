using Microsoft.AspNetCore.Mvc;
using PortFoliio.Models;
using System.Diagnostics;

namespace PortFoliio.Controllers
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
            ViewData["Message"] = " My name is Ayesha Arif. I am from Sialkot. I have completed my bachelor's degree or\r\nSoftware Engineering from university of Sialkot.";
            return View();
        }

        public ActionResult Index1()
        {
            TempData["Message"] = "Hello, World!";
            return RedirectToAction("About");
        }
        public ActionResult Index2()
        {
            // Using ViewData
            ViewData["Message"] = "My name is Ayesha Arif. I am from Sialkot. I have completed my bachelor's degree ";

            // Using ViewBag
            ViewBag.Message = "Hello, World!";

            // Using TempData
            TempData["Message"] = "Hello, World!";

            return View();
        }
        public ActionResult Index3()
        {
            ViewBag.Message = "My Name Is Ayesha";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Skill()
        {
            return View();
        }
        public IActionResult Contact()
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