using System;

namespace ReverseMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a message: C# is fun, I am going to code C# tomorrow");
            var message = Console.ReadLine();

            
            Console.WriteLine("Original message: " + message);

            var reversedMessage = ReverseString(message);
            Console.WriteLine("Reversed message: " + reversedMessage);

           
            Console.WriteLine("Message from top to bottom:");
            foreach (char letter in message)
            {
                Console.WriteLine(letter);
            }

            
            Console.WriteLine("Message from top to bottom in reverse:");
            foreach (char letter in reversedMessage)
            {
                Console.WriteLine(letter);
            }

            Console.ReadLine();
        }

        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
