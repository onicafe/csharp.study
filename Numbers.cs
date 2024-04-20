using System.Globalization;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 6;
            num--;

            Console.WriteLine(num);
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(3, 2));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Max(4, 90));
            Console.WriteLine(Math.Min(4, 90));
            Console.WriteLine(Math.Round(4.6));

            Console.ReadLine();
        }
    }
}