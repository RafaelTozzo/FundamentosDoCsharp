namespace FundamentosDoCsharp
{
    public class Struct
    {
        public static string RetornaNome(string nome, string sobrenome, int idade = 0)//Para um atributo ser opcional ele precisa ser inicializado e precisa estar no final / ultimo lugar
        {
            return nome + " " + sobrenome + " tem " + idade.ToString() + " anos de idade.";
        }

        public struct Product // O struct não pode estar dentro de outra classe
        {
            Product(int id, string name, double price)
            {
                Id = id;
                Name = name;
                Price = price;
            }

            public int Id;
            public string Name;
            public double Price;

            public double PriceInDolar(double dolar)
            {
                return Price * dolar;
            }
        }
    }
}