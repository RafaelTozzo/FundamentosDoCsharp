namespace FundamentosDoCsharp
{
    public class DatesWeekend
    {
        public static void DatesWeekendEx()
        {
            Console.WriteLine(DateTime.DaysInMonth(2022, 11));
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
        }

        public static bool IsWeekend(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }
    }
}