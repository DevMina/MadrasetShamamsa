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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
