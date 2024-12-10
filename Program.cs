using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 45, 12, 78, 34, 89, 23 };

        Console.WriteLine("Original Array: " + string.Join(", ", numbers));

        Array.Sort(numbers);
        Console.WriteLine("Sorted Array: " + string.Join(", ", numbers));

        Array.Reverse(numbers);
        Console.WriteLine("Reversed Array: " + string.Join(", ", numbers));

        numbers = numbers.Where(n => n != 78).ToArray();
        Console.WriteLine("Array after removing 78: " + string.Join(", ", numbers));

        int index = Array.IndexOf(numbers, 34);
        if (index == -1)
        {
            Console.WriteLine("34 does not exist in the array.");
        }
        else
        {
            Console.WriteLine("Index of 34: " + index);

            Console.ReadKey();
        }
    }
}
