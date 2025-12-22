using System.Diagnostics;
using MadrasetShamamsa.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadrasetShamamsa.Controllers
{
    public class EilomElKanesaController : Controller
    {
        public IActionResult EilomElKanesa()
        {
            return View();
        }
        public IActionResult Coptic()
        {
            return View("~/Views/EilomElKanesa/Coptic/Coptic.cshtml");
        }
        public IActionResult Akeda()
        {
            return View("~/Views/EilomElKanesa/Akeda/Akeda.cshtml");
        }
        public IActionResult TarekhElKanesa()
        {
            return View("~/Views/EilomElKanesa/TarekhElKanesa/TarekhElKanesa.cshtml");
        }
        public IActionResult Taqs()
        {
            return View("~/Views/EilomElKanesa/Taqs/Taqs.cshtml");
        }
        public IActionResult TaqsKodas() => View("~/Views/EilomElKanesa/Taqs/Taqs-Kodas/Taqs-Kodas.cshtml");
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
