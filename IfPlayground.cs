using System.Globalization;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();

            Console.WriteLine("\n\nShall we start? Type any number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Awesome! Type another number now");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Finally, the third one");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Processing results...");
            Thread.Sleep(1500);
            Console.Clear();

            LoadingBar();

            Thread.Sleep(3500);
            Console.Clear();

            Console.WriteLine(GetMax(num1, num2, num3) + ". \n\nIsn't it? ;)");
            Thread.Sleep(2500);
            Console.WriteLine("\n\nHope I got it right!\nThank you and see you next time!");
            Thread.Sleep(2500);
            Console.WriteLine("\\(^_^)");

            Console.ReadLine();
        }

        static void Intro()
        {
            Console.WriteLine("Let me test my skills!");
            Thread.Sleep(2500);
            Console.Clear();

            Console.WriteLine("Give me 3 numbers and I shall say which is the");
            Thread.Sleep(1500);
            Console.WriteLine("  _    _ _____ _____ _    _ ______  _____ _______ ");
            Console.WriteLine(" | |  | |_   _/ ____| |  | |  ____|/ ____|__   __|");
            Console.WriteLine(" | |__| | | || |  __| |__| | |__  | (___    | |   ");
            Console.WriteLine(" |  __  | | || | |_ |  __  |  __|  \\___ \\   | |   ");
            Console.WriteLine(" | |  | |_| || |__| | |  | | |____ ____) |  | |   ");
            Console.WriteLine(" |_|  |_|_____\\_____|_|  |_|______|_____/   |_|   ");
            Console.WriteLine("                                                  ");

            Thread.Sleep(1500);
        }

        static void LoadingBar()
        {
            Console.WriteLine("█                             |");
            Thread.Sleep(0500);
            Console.Clear();
            Console.WriteLine("██                            |");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("████                          |");
            Thread.Sleep(750);
            Console.Clear();
            Console.WriteLine("█████████                     |");
            Thread.Sleep(0250);
            Console.Clear();
            Console.WriteLine("███████████                   |");
            Thread.Sleep(0250);
            Console.Clear();
            Console.WriteLine("████████████                  |");
            Thread.Sleep(0250);
            Console.Clear();
            Console.WriteLine("█████████████                 |");
            Thread.Sleep(0250);
            Console.Clear();
            Console.WriteLine("███████████████████           |");
            Thread.Sleep(0250);
            Console.Clear();
            Console.WriteLine("████████████████████████      |");
            Thread.Sleep(0450);
            Console.Clear();
            Console.WriteLine("██████████████████████████████|");
            Thread.Sleep(1250);
            Console.Clear();
            Console.WriteLine("THE RESULTS ARE:");
            Thread.Sleep(0250);
        }


        static int GetMax(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }


    }
}