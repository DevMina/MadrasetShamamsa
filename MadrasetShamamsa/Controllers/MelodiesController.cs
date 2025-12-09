using System.Diagnostics;
using MadrasetShamamsa.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadrasetShamamsa.Controllers
{
    public class MelodiesController : Controller
    {
        public IActionResult MelodiesMain()
        {
            return View();
        }
        public IActionResult AnnualMain()
        {
            return View("~/Views/Melodies/Annual/AnnualMain.cshtml");
        }
        public IActionResult Section1_1() => View("~/Views/Melodies/Annual/Part1/Section1_1.cshtml");

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
