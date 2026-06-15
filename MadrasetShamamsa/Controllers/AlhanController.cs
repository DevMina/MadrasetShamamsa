using System.Diagnostics;
using MadrasetShamamsa.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadrasetShamamsa.Controllers
{
    public class AlhanController : Controller
    {
        List<string> maradatTawzie = new List<string>()
        {
            "<tr><td style=\"width:33%;\">يونان في بطن الحوت كمثال، المسيح في القبر ثلاثة أيام.</td><td style=\"width:33%;\">يوناه خين إثنيچي إمبي كيتوس كاطا إبتيبوس : إمبخرستوس خين بي إمهاڤ إن شومت إن إيهوؤو.</td><td style=\"width:33%; font-family:'CS New Athanasius'\" dir=\"ltr\">@Html.Raw(\"Iwna qen `;neji `mpikitoc kata `ptupoc @ `mP=,=c qen pi`mhau `nsomt `n`ehoou\")</td></tr>",
            "<tr><td style=\"width:33%;\">يسوع المسيح صام عنا، أربعين يومًا وأربعين ليلة</td><td style=\"width:33%;\">آ إيسوس بخرستوس إرنستيڤين إإهري إيجون إن إهميه إن إيهوؤو نيم إهميه إن إيجوره</td><td style=\"width:33%; font-family:'CS New Athanasius'\" dir=\"ltr\">@Html.Raw(\"A I=y=c P=,=c ernycteuin `e`hryi `ejwn@ `n`hme `n`eho`ou nem `hme `n`ejwrh\")</td></tr>"
        };
        public IActionResult AlhanList()
        {
            return View();
        }
        #region shared
        public IActionResult Tawzie()
        {
            return View("~/Views/Alhan/Sanawy/Tawzie/TawzieSanawy.cshtml");
        }
        #endregion shared
        #region Sanawy
        public IActionResult Sanawy() => View("~/Views/Alhan/Sanawy/Sanawy.cshtml");
        //RafaeBokhor
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
        public IActionResult OshytElKarabin() => View("~/Views/Alhan/Sanawy/KodasMawozen/OshytElKarabin.cshtml");
        public IActionResult LahnAlleloya() => View("~/Views/Alhan/Sanawy/KodasMawozen/LahnAlleloya.cshtml");
        public IActionResult Esbater() => View("~/Views/Alhan/Sanawy/KodasMawozen/Esbater.cshtml");
        public IActionResult SalatElShokrKodas() => View("~/Views/Alhan/Sanawy/KodasMawozen/SalatElShokrKodas.cshtml");
        public IActionResult SotesNeSavef() => View("~/Views/Alhan/Sanawy/KodasMawozen/SotesNeSavef.cshtml");
        public IActionResult TayShoryTeShory() => View("~/Views/Alhan/Sanawy/KodasMawozen/TayShoryTeShory.cshtml");
        public IActionResult Hetanyat() => View("~/Views/Alhan/Sanawy/KodasMawozen/Hetanyat.cshtml");
        public IActionResult BolesCoptic() => View("~/Views/Alhan/Sanawy/KodasMawozen/BolesCoptic.cshtml");
        public IActionResult BeEhmotGhar() => View("~/Views/Alhan/Sanawy/KodasMawozen/BeEhmotGhar.cshtml");
        public IActionResult Katholikon() => View("~/Views/Alhan/Sanawy/KodasMawozen/Katholikon.cshtml");
        public IActionResult KatholikonCoptic() => View("~/Views/Alhan/Sanawy/KodasMawozen/KatholikonCoptic.cshtml");
        public IActionResult Ebraksis() => View("~/Views/Alhan/Sanawy/KodasMawozen/Ebraksis.cshtml");
        public IActionResult EbraksisCoptic() => View("~/Views/Alhan/Sanawy/KodasMawozen/EbraksisCoptic.cshtml");
        public IActionResult MazmorEngel() => View("~/Views/Alhan/Sanawy/KodasMawozen/MazmorEngel.cshtml");
        public IActionResult AwashyKodasMawozen() => View("~/Views/Alhan/Sanawy/KodasBasily/AwashyKodasMawozen.cshtml");
        public IActionResult KanonElEman() => View("~/Views/Alhan/Sanawy/KodasBasily/KanonElEman.cshtml");
        //KodasBasily
        public IActionResult SalatElSolhBasily() => View("~/Views/Alhan/Sanawy/KodasBasily/SalatElSolhBasily.cshtml");
        public IActionResult EfrahyYaMariam() => View("~/Views/Alhan/Sanawy/KodasBasily/EfrahyYaMariam.cshtml");
        public IActionResult HetenNeEbresviaBasily() => View("~/Views/Alhan/Sanawy/KodasBasily/HetenNeEbresviaBasily.cshtml");
        public IActionResult AyohaElRab() => View("~/Views/Alhan/Sanawy/KodasBasily/AyohaElRab.cshtml");
        public IActionResult TasbehatElSharobem() => View("~/Views/Alhan/Sanawy/KodasBasily/TasbehatElSharobem.cshtml");
        public IActionResult MaradatToAwashy() => View("~/Views/Alhan/Sanawy/KodasBasily/MaradatToAwashy.cshtml");
        public IActionResult AwashyKodas() => View("~/Views/Alhan/Sanawy/KodasBasily/AwashyKodas.cshtml");
        public IActionResult MagmaeTarhem() => View("~/Views/Alhan/Sanawy/KodasBasily/MagmaeTarhem.cshtml");
        public IActionResult Kesma() => View("~/Views/Alhan/Sanawy/KodasBasily/Kesma.cshtml");
        public IActionResult Eatraf() => View("~/Views/Alhan/Sanawy/KodasBasily/Eatraf.cshtml");
        //Tawzie
        public IActionResult EkEsmaroot() => View("~/Views/Alhan/Sanawy/Tawzie/EkEsmaroot.cshtml");
        public IActionResult BeOik() => View("~/Views/Alhan/Sanawy/Tawzie/BeOik.cshtml");
        public IActionResult EsmaaoYaShaabElMaseh() => View("~/Views/Alhan/Sanawy/Tawzie/EsmaaoYaShaabElMaseh.cshtml");
        public IActionResult ElMagdLeManRafaaElSamawat() => View("~/Views/Alhan/Sanawy/Tawzie/ElMagdLeManRafaaElSamawat.cshtml");
        public IActionResult AbanaElLazy() => View("~/Views/Alhan/Sanawy/Tawzie/AbanaElLazy.cshtml");
        public IActionResult ElkhetamTawzie() => View("~/Views/Alhan/Sanawy/Tawzie/ElkhetamTawzie.cshtml");
        #endregion Sanawy
        #region KiahkChristmas
        public IActionResult KiahkChristmas() => View("~/Views/Alhan/KiahkChristmas/Kiahk/KiahkChristmas.cshtml");
        #region Kiahk
        //rf3bkhor
        public IActionResult ArbaeElnakosKiahk() => View("~/Views/Alhan/KiahkChristmas/Kiahk/ArbaeElnakosKiahk.cshtml");
        public IActionResult ZoksologiatKiahk() => View("~/Views/Alhan/KiahkChristmas/Kiahk/ZoksologiatKiahk.cshtml");
        public IActionResult MazmorEngelKiahk() => View("~/Views/Alhan/KiahkChristmas/Kiahk/MazmorEngelKiahk.cshtml");
        public IActionResult ElkhetamKiahk() => View("~/Views/Alhan/KiahkChristmas/Kiahk/ElkhetamKiahk.cshtml");
        //kodas
        public IActionResult HetanyatKiahk() => View("~/Views/Alhan/KiahkChristmas/Kiahk/HetanyatKiahk.cshtml");
        public IActionResult EbraksisKiahk() => View("~/Views/Alhan/KiahkChristmas/Kiahk/EbraksisKiahk.cshtml");
        public IActionResult MazmorEngelKiahkKodas() => View("~/Views/Alhan/KiahkChristmas/Kiahk/MazmorEngelKiahkKodas.cshtml");
        public IActionResult AsbazmosWatosKiahk() => View("~/Views/Alhan/KiahkChristmas/Kiahk/AsbazmosWatosKiahk.cshtml");
        public IActionResult AsbazmosAdamKiahk() => View("~/Views/Alhan/KiahkChristmas/Kiahk/AsbazmosAdamKiahk.cshtml");
        //tawze3
        public IActionResult TawzieKiahk() => View("~/Views/Alhan/KiahkChristmas/Kiahk/TawzieKiahk.cshtml");
        public IActionResult JeEfEsmarootKiahk() => View("~/Views/Alhan/KiahkChristmas/Kiahk/JeEfEsmarootKiahk.cshtml");
        public IActionResult TawzieAyamKiahk() => View("~/Views/Alhan/KiahkChristmas/Kiahk/TawzieAyamKiahk.cshtml");
        public IActionResult TawzieAhadKiahk() => View("~/Views/Alhan/KiahkChristmas/Kiahk/TawzieAhadKiahk.cshtml");
        public IActionResult ElkhetamTawzieKiahk() => View("~/Views/Alhan/KiahkChristmas/Kiahk/ElkhetamTawzieKiahk.cshtml");

        #endregion Kiahk
        #region BaramonElMelad
        //rf3bkhor
        public IActionResult ArbaeElnakosBaramonElMelad() => View("~/Views/Alhan/KiahkChristmas/BaramonElMelad/ArbaeElnakosBaramonElMelad.cshtml");
        public IActionResult ZoksologiatKiahkBaramonElMelad() => View("~/Views/Alhan/KiahkChristmas/BaramonElMelad/ZoksologiatKiahkBaramonElMelad.cshtml");

        #endregion BaramonElMelad
        #region EidElMelad
        //rf3bkhor
        public IActionResult ArbaeElnakosEidElMelad() => View("~/Views/Alhan/KiahkChristmas/EidElMelad/ArbaeElnakosEidElMelad.cshtml");
        public IActionResult ZoksologiatEidElMelad() => View("~/Views/Alhan/KiahkChristmas/EidElMelad/ZoksologiatEidElMelad.cshtml");
        public IActionResult MazmorEngelEidElMelad() => View("~/Views/Alhan/KiahkChristmas/EidElMelad/MazmorEngelEidElMelad.cshtml");
        public IActionResult ElkhetamEidElMelad() => View("~/Views/Alhan/KiahkChristmas/EidElMelad/ElkhetamEidElMelad.cshtml");

        #endregion EidElMelad
        #endregion KiahkChristmas
        #region ElSoomElKber
        public IActionResult ElSoomElKber() => View("~/Views/Alhan/ElSoomElKber/ElSoomElKber.cshtml");
        public IActionResult ZoksologiatElSoomElKber() => View("~/Views/Alhan/ElSoomElKber/ZoksologiatElSoomElKber.cshtml");
        public IActionResult MaradElEngelElSoomElKber() => View("~/Views/Alhan/ElSoomElKber/MaradElEngelElSoomElKber.cshtml");
        public IActionResult ElkhetamElSoomElKber() => View("~/Views/Alhan/ElSoomElKber/ElkhetamElSoomElKber.cshtml");
        #endregion ElSoomElKber
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
