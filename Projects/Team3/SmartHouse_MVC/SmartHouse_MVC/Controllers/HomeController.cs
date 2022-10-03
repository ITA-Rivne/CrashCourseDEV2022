using Microsoft.AspNetCore.Mvc;
using SmartHouse_MVC.Models;
using System.Diagnostics;

namespace SmartHouse_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private HouseModel _model;   
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //_model = new HouseModel();  
        }

        public IActionResult Index()
        {
            // added
            HouseModel hModel = new HouseModel();
            //return View(_model);
            return View(hModel);
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