using HousePlants.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HousePlants.Controllers
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
            // create new view model
            //get list of plants from database
            //iterrate list of plants be creating new plant model and adding it to the list of plants
            //
            var pothos = new Plant("Pothos", "/sun-icons/any.png", "/plant-images/pothos.PNG", "Moderately Dry", "Poisonous");
            var peperomia = new Plant("Peperomina", "/sun-icons/low-medium.png", "/plant-images/peperomia.PNG", "Allow soil to dry", "Poisonous");
            var chineseEvergreen = new Plant("Chinese Evergreen", "/sun-icons/low-medium.png", "/plant-images/chinese-evergreen.PNG", "Keep Evenly Moist", "Poisonous");



            var model = new IndexViewModel();

            model.plantList.Add(pothos);
            model.plantList.Add(peperomia);
            model.plantList.Add(chineseEvergreen);
            return View(model);
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
