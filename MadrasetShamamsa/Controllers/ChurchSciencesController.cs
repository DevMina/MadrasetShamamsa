using System.Diagnostics;
using MadrasetShamamsa.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadrasetShamamsa.Controllers
{
    public class ChurchSciencesController : Controller
    {
        public IActionResult SciencesMain()
        {
            return View();
        }
        public IActionResult Coptic()
        {
            return View("~/Views/ChurchSciences/Coptic/Coptic.cshtml");
        }
        public IActionResult Dogma()
        {
            return View("~/Views/ChurchSciences/Dogma/Dogma.cshtml");
        }
        public IActionResult History()
        {
            return View("~/Views/ChurchSciences/History/History.cshtml");
        }
        public IActionResult Rite()
        {
            return View("~/Views/ChurchSciences/Rite/Rite.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
