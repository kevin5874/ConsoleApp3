using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Double.Parse(Console.ReadLine());
            x *= 50;
            printConsole(x);
            x = getInput();
            x += 25;
            printConsole(x);
            x = getInput();
            x /= 12.5;
            printConsole(x);
            x = getInput();
            bool y = x > 50 ? true : false;
            Console.WriteLine(y);
            x = getInput();
            x %= 7;
            printConsole(x);
            Console.ReadKey();
            

        }
        public static void printConsole(double y)
        {
            Console.WriteLine(y);
        }
        public static double getInput()
        {
            
            double result = Double.Parse(Console.ReadLine());
            return result;
        }
    }
}
