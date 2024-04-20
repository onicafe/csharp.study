using System.Globalization;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Mike", 60);
            SayHi("Vanilla", 6);
            SayHi("binky", 13);
            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hi " + name);
            Console.WriteLine("You are " + age);
        }
    }
}