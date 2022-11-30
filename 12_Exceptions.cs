namespace FundamentosDoCsharp
{
    public class Exceptions
    {
        public static void ExceptionsEx()
        {
            var meuArray = new int[3] { 5, 10, 15 };

            try
            {
                // for (int i = 0; i < 5; i++)
                // {
                //     Console.WriteLine(meuArray[i]);
                // }

                Cadastrar("");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei o índice na lista");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Falha ao cadastrar texto");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops, algo deu errado!");
            }
            finally
            {
                Console.WriteLine("Entrar em contato com o suporte.");
            }
        }

        private static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                // throw new ArgumentNullException("O texto não pode ser nulo ou vazio!");
                throw new MinhaException(DateTime.Now);
            }
        }

        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }

            public DateTime QuandoAconteceu { get; set; }
        }
    }
}