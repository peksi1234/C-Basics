using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Loops_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many times do you want this loop to run? ");
            string message = Console.ReadLine();

            Console.Write("How many times do you want it to repeat? ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= loopCounter; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Loop finished");
            Console.ReadLine();
        }
    }
}

