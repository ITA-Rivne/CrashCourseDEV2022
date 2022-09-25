using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Team1_Web.Models;

namespace Team1_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeModel homeModel = new HomeModel();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(homeModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public string StartFairyTale(int number1, int number2)
        {
            return homeModel.StartFairyTale();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}