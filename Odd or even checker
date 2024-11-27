using System;

namespace OddEvenChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a number:");

            
            int number;
            bool isValidInput = int.TryParse(Console.ReadLine(), out number);

            if (isValidInput)
            {
                
                if (number % 2 == 0)
                {

                    Console.WriteLine($"The number {number} is even.");
                }
                else
                {
                  
                    Console.WriteLine($"The number {number} is odd.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            Console.ReadLine();
        }
    }
}
