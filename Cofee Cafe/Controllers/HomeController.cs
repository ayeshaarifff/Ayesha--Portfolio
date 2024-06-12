using Cofee_Cafe.Controllers.Data;
using Cofee_Cafe.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cofee_Cafe.Controllers
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
            
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.Message = "We have Special Message From Controller";
            ViewData["Message"] = " We have Special Message From Controller";
            TempData["Message"] = "Message for another action method";
            return View();
        }
        public IActionResult About()
        {

            return View();
        }

        public IActionResult Test(string uname, string upass)
        {
            if(uname=="Ayesha" && upass=="1234" )
                {
                ViewBag.Message = "Login Successfully";
            }
            else
            {
                ViewBag.Message = "Login Failed";
            }
            return View("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}