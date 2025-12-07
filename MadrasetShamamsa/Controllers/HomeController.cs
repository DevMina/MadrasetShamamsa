using System.Diagnostics;
using MadrasetShamamsa.Interfaces;
using MadrasetShamamsa.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadrasetShamamsa.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICopticDateService _copticDateService;

        public HomeController(ICopticDateService copticDateService)
        {
            _copticDateService = copticDateService;
        }
        public IActionResult Index()
        {
            ViewBag.CopticDate = _copticDateService.ToCopticDate(DateTime.Now);
            return View();
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
