using System.Globalization;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {

            string characterName = "Vanilla";
            int characterAge;
            characterAge = 6;

            Console.WriteLine("Hi, " + characterName);
            Console.WriteLine("Oh, you are " + characterAge + " y old!");
            Console.WriteLine(characterName + " is a Persian cat");

            characterName = "Vanyan";
            Console.WriteLine("a " + characterAge + "y old Persian cat named " + characterName);

            Console.ReadLine();
        }
    }
}