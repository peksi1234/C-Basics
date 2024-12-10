using System;

namespace SwitchCaseExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Counter = 1;


            while (Counter <= 5)
            {
                Console.WriteLine($"Counter: {Counter}");
                Counter++;
            }


            switch (Counter)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }

            Console.ReadLine();
        }
    }
}
