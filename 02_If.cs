namespace FundamentosDoCsharp
{
    public class If
    {
        public static void IfEx()
        {
            //---  ---  Estruturas Condicionais: IF  ---  ---

            Console.WriteLine("Digite um numero entre 0 - 50!");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite outro numero entre 0 - 50!");
            double n2 = Convert.ToDouble(Console.ReadLine());

            if (n1 > n2 && n1 > 0 && n1 <= 50)
            {
                Console.WriteLine($"{n1} é maior que {n2}!");
            }
            else if (n2 > n1 && n2 > 0 && n2 <= 50)
            {
                Console.WriteLine($"{n2} é maior que {n1}!");
            }
            else
            {
                Console.WriteLine("Numero digitado não é valido");
            }
            
        }
    }
}