using Microsoft.AspNetCore.Mvc;
using SmartHouse_MVC.Models;
using System.Diagnostics;

namespace SmartHouse_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HouseModel HModel { get; set; } = new HouseModel();   
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //_model = new HouseModel();  
        }

        public IActionResult Index()
        {
            // added
            //HouseModel hModel = new HouseModel();
            //return View(_model);
            return View(HModel);
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
        
        public IActionResult Monitoring(int temperature = 20)
        {
            HModel.House.Temperature = 0;// temperature; // !!!!!
            
            return View(HModel);
        }
    }
}