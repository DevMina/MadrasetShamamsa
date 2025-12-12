using System.Diagnostics;
using MadrasetShamamsa.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadrasetShamamsa.Controllers
{
    public class AlhanController : Controller
    {
        public IActionResult AlhanList()
        {
            return View();
        }
        public IActionResult Sanawy()
        {
            return View("~/Views/Alhan/Sanawy/Sanawy.cshtml");
        }
        public IActionResult SalatElShokr() => View("~/Views/Alhan/Sanawy/RafaeBokhor/SalatElShokr.cshtml");
        public IActionResult ArbaeElnakos() => View("~/Views/Alhan/Sanawy/RafaeBokhor/ArbaeElnakos.cshtml");
        public IActionResult Awashy() => View("~/Views/Alhan/Sanawy/RafaeBokhor/Awashy.cshtml");
        public IActionResult Zoksologiat() => View("~/Views/Alhan/Sanawy/RafaeBokhor/Zoksologiat.cshtml");

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
