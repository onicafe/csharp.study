using System.Globalization;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();


            Console.WriteLine("Hello " + name + ". You are " + age);

            Console.ReadLine();
        }
    }
}