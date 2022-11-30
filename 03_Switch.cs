namespace FundamentosDoCsharp
{
    public class Switch
    {
        public static void SwitchEx()
        {
            // ---  ---  Estruturas Condicionais: SWITCH  ---  ---

            int valor = 1;
            switch (valor)
            {
                case 1: Console.WriteLine("1"); break;
                case 2: Console.WriteLine("2"); break;
                case 3: Console.WriteLine("3"); break;
                default: Console.WriteLine("4"); break;
            }

            string name = "Juca";
            switch (name)
            {
                case "Maria": Console.WriteLine("Usuario secundario"); break;
                case "Ricardo": Console.WriteLine("Não cadastrado"); break;
                case "Juca": Console.WriteLine("Usuario principal"); break;
                default: Console.WriteLine("Outro usuario"); break;
            }
        }
    }
}