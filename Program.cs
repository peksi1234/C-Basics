using System;

namespace Boolean_Uppgift_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;
            int num4 = 10;

            Console.WriteLine("Value of num1: " + num1);
            Console.WriteLine("Value of num2: " + num2);
            Console.WriteLine("Value of num3: " + num3);
            Console.WriteLine("Value of num4: " + num4);

            bool comparison1 = (num1 > num3);
            bool comparison2 = (num2 < num4);
            bool comparison3 = (num1 == num4);
            bool comparison4 = (num2 != num3);

            Console.WriteLine("Is num1 greater than num3? " + comparison1);
            Console.WriteLine("Is num2 less than num4? " + comparison2);
            Console.WriteLine("Is num1 equal to num4? " + comparison3);
            Console.WriteLine("Is num2 not equal to num3? " + comparison4);

            bool expression1 = (num1 > num3) && (num2 < num4);
            bool expression2 = (num1 < num3) || (num2 > num4);

            Console.WriteLine("Value of expression1 (num1 > num3 && num2 < num4): " + expression1);
            Console.WriteLine("Value of expression2 (num1 < num3 || num2 > num4): " + expression2);

            Console.ReadLine();
        }
    }
}
