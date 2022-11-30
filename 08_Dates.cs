namespace FundamentosDoCsharp
{
    public class Dates
    {
        public static void DatesEx()
        {
            /*
            var data = DateTime.Now;

            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.AddYears(10));
            Console.WriteLine(data.AddYears(10).Year);

            // Print nos dias da semana
            Console.WriteLine(data);

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(data.ToString("dddd"));
                data = data.AddDays(1);
            }
            */


            // Print meses do ano
            /*
            var data = new DateTime();
            Console.WriteLine(data);

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(data.ToString("MMMM"));
                data = data.AddMonths(1);
            }

            // Obs:    para meses abreviado: data.ToString("MMM")
            //         para meses por extenso: data.ToString("MMMM")
            */


            //  Formatação Datas:
            /*
            var data = DateTime.Now;
            var formatada = data.ToString("dd/MM/yyyy");
            Console.WriteLine(formatada);
            */


            //Exibe o formato completo da data
            /*
            var data = DateTime.Now;
	        var formatada = data.ToString("D"); 
            Console.WriteLine(formatada);
            */


            // Usado para converter para JSON, muito utilizado no frontend
            /*
            var data = DateTime.Now;
	        var formatada = data.ToString("s"); 
            Console.WriteLine(formatada);
            */


            // Padrão universal bastante utilizado no JSON
            /*
	        var data = DateTime.Now;
	        var formatada = data.ToString("u"); 
            Console.WriteLine(formatada);
            */
        }
    }
}