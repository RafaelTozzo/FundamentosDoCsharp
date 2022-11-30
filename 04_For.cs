namespace FundamentosDoCsharp
{
    public class For
    {
        public static void ForEx()
        {
            //---  ---  Laço de repetição: FOR  ---  ---

            for (var i = 0; i <= 100; i += 5)
            {
                Console.WriteLine($"Somando de 5 em 5: {i}");
            }

            for (var i = 0; i <= 10; i += 2)
            {
                Console.WriteLine($"Somando de 2 em 2: {i}");
            }

            for (int i = 50; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}