using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace InTheBag.Controllers
{
    public class GenieController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string GenieName, int Age, int WishesGranted)
        {
            if (WishesGranted > 5000 || Age > 1000)
                return View("ExperiencedGenie");
            else
                return View("Novice");
        }
        public IActionResult Create(string GenieName)
        {
            int numGranted = Int32.Parse(Request.Form["WishesGranted"]);
            int Years = Int32.Parse(Request.Form["Age"]);

            if (numGranted > 5000 || Years > 1000)
                return View("ExperiencedGenie");
            else
                return View("Novice");
        }
        public IActionResult Create2()
        {
            var name = RouteData.Values["GenieName"];
            var numGranted = Int32.Parse(Request.Form["WishesGranted"]);
            var Years = Int32.Parse(Request.Form["Age"]);

            if (numGranted > 5000 || Years > 1000)
                return View("ExperiencedGenie");
            else
                return View("Novice");
        }
        public IActionResult Perks()
        {
            ViewBag.Posted = false;
            return View();
        }
        [HttpPost]
        public IActionResult Perks(string[] perk)
        {
            ViewBag.Posted = true;
            ViewBag.Perks = perk;
            return View();
        }
    }
}
