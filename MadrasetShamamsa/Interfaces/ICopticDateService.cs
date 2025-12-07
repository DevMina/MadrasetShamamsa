namespace MadrasetShamamsa.Interfaces
{
    public interface ICopticDateService
    {
        string ToCopticDate(DateTime date);
        string ToCopticDate(DateTime date, string language);
        string GetMonthName(int month, string language = "en");
    }
}