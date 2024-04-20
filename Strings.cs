using System.Globalization;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Overwatch\nAcademy\"" + "\n is cool";

            Console.WriteLine(phrase.Substring(8, 3));

            Console.ReadLine();
        }
    }
}