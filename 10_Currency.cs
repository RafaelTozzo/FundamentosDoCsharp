using System.Globalization;

namespace FundamentosDoCsharp
{
    public class Currency
    {
        public static void CurrencyEx()
        {
            decimal valor = 10.25m;
            // Console.WriteLine(valor);

            // Muda a forma monetaria de acordo com o pais:
            // "C" = Adiciona a Currency especifica do pais:
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            
            // Arredondar os valores:
            Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Round(valor).ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
        }
    }
}