using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 0, 1, 2, 3, 4, 5 };

        int sum = SumOfNumbers(numbers);
        Console.WriteLine($"Array Length: {numbers.Length}");

        if (numbers.Length > 0)
        {
            if (sum > -1)
            {
                Console.WriteLine($"The total is: {sum}");
            }
            else
            {
                Console.WriteLine("The total is negative and cannot be processed.");
            }
        }
        else
        {
            Console.WriteLine("Cannot add up an empty array.");
        }
    }

    static int SumOfNumbers(int[] array)
    {
        int sum = 0;
        foreach (int number in array)
        {
            sum += number;
        }
        return sum;
    }
}
