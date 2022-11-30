
namespace FundamentosDoCsharp
{
    public class Convert
    {
        public static void ConvertEx()
        {
            //---  ---  Convert:  ---  ---

            int inteiro = 50;
            float real = 25.35f;
            inteiro = (int)real;
            inteiro = System.Convert.ToInt32(real);

            Console.WriteLine(inteiro);
        }

        internal static double ToDouble(string? v)
        {
            throw new NotImplementedException();
        }
    }
}