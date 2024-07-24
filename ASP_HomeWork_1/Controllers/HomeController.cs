using ASP_HomeWork_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_HomeWork_1.Controllers
{
    public class HomeController : Controller
    {

        public List<Drink> drinks = new List<Drink>
        {
            new Drink { Name = "Cola" },
            new Drink { Name = "Orange Juice" },
            new Drink { Name = "Water" }
        };

        // Hotmeals listesi
        public List<Hotmeal> hotmeals = new List<Hotmeal>
        {
            new Hotmeal { Name = "Spaghetti Bolognese" },
            new Hotmeal { Name = "Chicken Curry" },
            new Hotmeal { Name = "Lasagna" }
        };

        public // Fastfoods listesi
        List<Fastfood> fastfoods = new List<Fastfood>
        {
            new Fastfood { Name = "Hamburger" },
            new Fastfood { Name = "Pizza" },
            new Fastfood { Name = "French Fries" }
        };




        public IActionResult Index()
        {

            var foodBox = new FoodsBox()
            {
                Drinks = drinks,
                Hotmeals = hotmeals,
                Fastfoods = fastfoods
            };


            return View(foodBox);
        }

        public IActionResult DrinksList()
        {
            return View(drinks);
        }
        public IActionResult HotmealList()
        {
            return View(hotmeals);
        }
        public IActionResult FastfoodList()
        {
            return View(fastfoods);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
