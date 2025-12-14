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
        }//RafaeBokhor
        public IActionResult SalatElShokr() => View("~/Views/Alhan/Sanawy/RafaeBokhor/SalatElShokr.cshtml");
        public IActionResult ArbaeElnakos() => View("~/Views/Alhan/Sanawy/RafaeBokhor/ArbaeElnakos.cshtml");
        public IActionResult Awashy() => View("~/Views/Alhan/Sanawy/RafaeBokhor/Awashy.cshtml");
        public IActionResult Zoksologiat() => View("~/Views/Alhan/Sanawy/RafaeBokhor/Zoksologiat.cshtml");
        public IActionResult OshytElEngel() => View("~/Views/Alhan/Sanawy/RafaeBokhor/OshytElEngel.cshtml");
        public IActionResult Elkhetam() => View("~/Views/Alhan/Sanawy/RafaeBokhor/Elkhetam.cshtml");
        //KodasMawozen
        public IActionResult LahnAlbaraka() => View("~/Views/Alhan/Sanawy/KodasMawozen/LahnAlbaraka.cshtml");
        public IActionResult LahnEkEsmaroot() => View("~/Views/Alhan/Sanawy/KodasMawozen/LahnEkEsmaroot.cshtml");
        public IActionResult LahnEflogemenos() => View("~/Views/Alhan/Sanawy/KodasMawozen/LahnEflogemenos.cshtml");
        public IActionResult LahnEbooro() => View("~/Views/Alhan/Sanawy/KodasMawozen/LahnEbooro.cshtml");
        public IActionResult LahnAllyAbinaf() => View("~/Views/Alhan/Sanawy/KodasMawozen/LahnAllyAbinaf.cshtml");
        public IActionResult LahnAlleloya() => View("~/Views/Alhan/Sanawy/KodasMawozen/LahnAlleloya.cshtml");
        public IActionResult ZoksabatrySotes() => View("~/Views/Alhan/Sanawy/KodasMawozen/ZoksabatrySotes.cshtml");
        public IActionResult NeSavef() => View("~/Views/Alhan/Sanawy/KodasMawozen/NeSavef.cshtml");
        public IActionResult TayShoryTeShory() => View("~/Views/Alhan/Sanawy/KodasMawozen/TayShoryTeShory.cshtml");
        public IActionResult Hetanyat() => View("~/Views/Alhan/Sanawy/KodasMawozen/Hetanyat.cshtml");
        public IActionResult BolesCoptic() => View("~/Views/Alhan/Sanawy/KodasMawozen/BolesCoptic.cshtml");
        public IActionResult BeEhmotGhar() => View("~/Views/Alhan/Sanawy/KodasMawozen/BeEhmotGhar.cshtml");
        public IActionResult EiAghaby() => View("~/Views/Alhan/Sanawy/KodasMawozen/EiAghaby.cshtml");
        public IActionResult Katholikon() => View("~/Views/Alhan/Sanawy/KodasMawozen/Katholikon.cshtml");
        public IActionResult KatholikonCoptic() => View("~/Views/Alhan/Sanawy/KodasMawozen/KatholikonCoptic.cshtml");
        public IActionResult Ebraksis() => View("~/Views/Alhan/Sanawy/KodasMawozen/Ebraksis.cshtml");
        public IActionResult EbraksisCoptic() => View("~/Views/Alhan/Sanawy/KodasMawozen/EbraksisCoptic.cshtml");
        public IActionResult KhenEfran() => View("~/Views/Alhan/Sanawy/KodasMawozen/KhenEfran.cshtml");
        public IActionResult MazmorEngel() => View("~/Views/Alhan/Sanawy/KodasMawozen/MazmorEngel.cshtml");
        //KodasBasily
        public IActionResult KanonElEman() => View("~/Views/Alhan/Sanawy/KodasBasily/KanonElEman.cshtml");
        public IActionResult SalatElSolhBasily() => View("~/Views/Alhan/Sanawy/KodasBasily/SalatElSolhBasily.cshtml");
        public IActionResult EfrahyYaMariam() => View("~/Views/Alhan/Sanawy/KodasBasily/EfrahyYaMariam.cshtml");
        public IActionResult HetenNeEbresviaBasily() => View("~/Views/Alhan/Sanawy/KodasBasily/HetenNeEbresviaBasily.cshtml");
        public IActionResult AyohaElRab() => View("~/Views/Alhan/Sanawy/KodasBasily/AyohaElRab.cshtml");
        public IActionResult TasbehatElSharobem() => View("~/Views/Alhan/Sanawy/KodasBasily/TasbehatElSharobem.cshtml");
        public IActionResult MaradatToEatraf() => View("~/Views/Alhan/Sanawy/KodasBasily/MaradatToEatraf.cshtml");
        //KodasGhorighory
        public IActionResult SalatElSolhGreg() => View("~/Views/Alhan/Sanawy/KodasGhorighory/SalatElSolhGreg.cshtml");
        public IActionResult HetenNeEbresviaGreg() => View("~/Views/Alhan/Sanawy/KodasGhorighory/HetenNeEbresviaGreg.cshtml");
        public IActionResult YarabErham() => View("~/Views/Alhan/Sanawy/KodasGhorighory/YarabErham.cshtml");
        public IActionResult MaradatToEsma() => View("~/Views/Alhan/Sanawy/KodasGhorighory/MaradatToEsma.cshtml");
        //Maradat
        public IActionResult OshytElKarabin() => View("~/Views/Alhan/Sanawy/Maradat/OshytElKarabin.cshtml");
        public IActionResult EsbaterElKbera() => View("~/Views/Alhan/Sanawy/Maradat/EsbaterElKbera.cshtml");
        public IActionResult TobhHenaElKbera() => View("~/Views/Alhan/Sanawy/Maradat/TobhHenaElKbera.cshtml");
        public IActionResult KabeloElKbera() => View("~/Views/Alhan/Sanawy/Maradat/KabeloElKbera.cshtml");
        public IActionResult BeNeshty() => View("~/Views/Alhan/Sanawy/Maradat/BeNeshty.cshtml");
        public IActionResult AmenElEatrafElKbera() => View("~/Views/Alhan/Sanawy/Maradat/AmenElEatrafElKbera.cshtml");
        //Tawzie
        public IActionResult TawzieSanawy() => View("~/Views/Alhan/Sanawy/Tawzie/TawzieSanawy.cshtml");
        public IActionResult EkEsmaroot() => View("~/Views/Alhan/Sanawy/Tawzie/EkEsmaroot.cshtml");
        public IActionResult BeOik() => View("~/Views/Alhan/Sanawy/Tawzie/BeOik.cshtml");
        public IActionResult EsmaaoYaShaabElMaseh() => View("~/Views/Alhan/Sanawy/Tawzie/EsmaaoYaShaabElMaseh.cshtml");
        public IActionResult ElMagdLeManRafaaElSamawat() => View("~/Views/Alhan/Sanawy/Tawzie/ElMagdLeManRafaaElSamawat.cshtml");
        public IActionResult AbanaElLazy() => View("~/Views/Alhan/Sanawy/Tawzie/AbanaElLazy.cshtml");
        public IActionResult ElkhetamTawzie() => View("~/Views/Alhan/Sanawy/Tawzie/ElkhetamTawzie.cshtml");

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
