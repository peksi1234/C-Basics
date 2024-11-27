﻿using System;

namespace PasswordValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter a password:");
            string password1 = Console.ReadLine();

            
            Console.WriteLine("Please re-enter your password:");
            string password2 = Console.ReadLine();

            
            if (string.IsNullOrEmpty(password1) || string.IsNullOrEmpty(password2))
            {
                
                Console.WriteLine("Please enter a password");
            }
            else if (password1.Length < 6 || password2.Length < 6)
            {
              
                Console.WriteLine("Passwords must be at least 6 characters long");
            }
            else if (password1 == password2)
            {
                
                Console.WriteLine("Password match");
            }
            else
            {
                
                Console.WriteLine("Passwords do not match");
            }

            Console.ReadLine();
        }
    }
}
