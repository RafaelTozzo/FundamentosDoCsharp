namespace FundamentosDoCsharp
{
    public class Arrays
    {
        public static void ArraysEx()
        {
            var meuArray = new int[4] { 5, 10, 15, 20 };

            // Console.WriteLine(meuArray[0]);
            // Console.WriteLine(meuArray[1]);
            // Console.WriteLine(meuArray[2]);
            // Console.WriteLine(meuArray[3]);

            // for (int i = 0; i < meuArray.Length; i++)
            // {
            //     Console.WriteLine(meuArray[i]);
            // }

            foreach (var item in meuArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}