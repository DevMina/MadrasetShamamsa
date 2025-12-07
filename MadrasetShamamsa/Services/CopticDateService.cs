using MadrasetShamamsa.Interfaces;
using NodaTime;

namespace MadrasetShamamsa.Services
{
    public class CopticDateService : ICopticDateService
    {
        private static readonly string[] EnglishMonths =
        [
            "Tute", "Babah", "Hatour", "Kiahk", "Tubah", "Amshir",
            "Baramhat", "Baramoudah", "Bashans", "Baounah", "Abib", "Misra", "El-Nasi"
        ];

        private static readonly string[] ArabicMonths =
        [
            "توت", "بابه", "هاتور", "كيهك", "طوبه", "أمشير",
            "برمهات", "برموده", "بشنس", "بؤونه", "أبيب", "مسرى", "النسئ"
        ];

        public string ToCopticDate(DateTime date)
        {
            string language = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.ToLower();
            return ToCopticDate(date, language);
        }

        public string ToCopticDate(DateTime date, string language)
        {
            var localDate = LocalDate.FromDateTime(date, CalendarSystem.Gregorian)
                                     .WithCalendar(CalendarSystem.Coptic);

            string suffix = language == "ar" ? "ش" : "A.M.";

            return $"{localDate.Day} {GetMonthName(localDate.Month, language)} {localDate.Year} {suffix}";
        }

        public string GetMonthName(int month, string language = "en")
        {
            if (month < 1 || month > 13)
                throw new ArgumentOutOfRangeException(nameof(month), "Month must be between 1 and 13");

            return language.ToLower() switch
            {
                "ar" => ArabicMonths[month - 1],
                _ => EnglishMonths[month - 1]
            };
        }
    }
}