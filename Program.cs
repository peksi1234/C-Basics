
using System;
using System.Collections.Generic;

class DictionaryCaseTask
{
    static void Main(string[] args)
    {
        Dictionary<string, string> subjects = new Dictionary<string, string>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1 - Add a new subject");
            Console.WriteLine("2 - Remove a subject");
            Console.WriteLine("3 - Display all subjects and their teachers");
            Console.WriteLine("4 - Exit the program");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the name of the new subject: ");
                    string newSubject = Console.ReadLine();
                    Console.Write("Enter the teacher's name for this subject: ");
                    string teacherName = Console.ReadLine();

                    if (!subjects.ContainsKey(newSubject))
                    {
                        subjects[newSubject] = teacherName;
                        Console.WriteLine($"Subject '{newSubject}' with teacher '{teacherName}' added successfully.");
                    }
                    else
                    {
                        Console.WriteLine($"Subject '{newSubject}' already exists.");
                    }
                    break;

                case "2":
                    Console.Write("Enter the name of the subject to remove: ");
                    string subjectToRemove = Console.ReadLine();

                    if (subjects.Remove(subjectToRemove))
                    {
                        Console.WriteLine($"Subject '{subjectToRemove}' removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine($"Subject '{subjectToRemove}' not found.");
                    }
                    break;

                case "3":
                    if (subjects.Count > 0)
                    {
                        Console.WriteLine("\nSubjects and their teachers:");
                        foreach (var subject in subjects)
                        {
                            Console.WriteLine($"{subject.Key} - {subject.Value}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No subjects found.");
                    }
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}