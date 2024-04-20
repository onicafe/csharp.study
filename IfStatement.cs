using System.Globalization;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isFemale = true;
            bool isShort = true;

            if (isFemale && isShort)
            {
                Console.WriteLine("Hewwo short girlie");
            }
            else if (isFemale && !isShort)
            {
                Console.WriteLine("Hewwo girlie");
            }
            else if (!isFemale && isShort)
            {
                Console.WriteLine("look, a short boy");
            }
            else
            {
                Console.WriteLine("move on...");
            }

            Console.ReadLine();
        }
    }
}