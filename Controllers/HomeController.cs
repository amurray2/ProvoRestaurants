using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProvoRestaurants.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProvoRestaurants.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Handles my top 5
        [HttpGet]
        public IActionResult Index()
        {
            List<string> RestaurantList = new List<string>();

            foreach(Top5 r in Top5.GetTop5s())
            {
                string? FavDish = r.FavDish ?? "It's All Tasty";
                string? phoneNumber = r.Phone ?? "No Phone Number";

                RestaurantList.Add("#" + r.Rank + ". " + r.RestaurantName +
                    ", most popular dish: " + FavDish + ". " + r.Address + " | " + phoneNumber +
                    ": " + r.Website);
            }
            return View(RestaurantList);
        }

        [HttpGet]
        public IActionResult CreateSuggestions()
        {
            return View();
        }

        //Create Suggestions post method
        [HttpPost]
        public IActionResult CreateSuggestions(Suggestions suggestions)
        {
            if (ModelState.IsValid)
            {
                SuggestionStorage.AddSuggestion(suggestions);
                return RedirectToAction("CreateSuggestions");
            }
            return View();
        }

        [HttpGet]
        public IActionResult SuggestionList()
        {

            return View(SuggestionStorage.suggestionList);
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
