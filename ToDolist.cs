using System;
using System.Collections.Generic;

class ToDoList
{
    static void Main()
    {
        List<string> tasks = new List<string>();
        string input;

        do
        {
            Console.WriteLine("\nTo-Do List:");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Remove Task");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Enter a new task: ");
                    string task = Console.ReadLine();
                    tasks.Add(task);
                    Console.WriteLine("Task added.");
                    break;

                case "2":
                    Console.WriteLine("\nYour Tasks:");
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {tasks[i]}");
                    }
                    break;

                case "3":
                    Console.Write("Enter the task number to remove: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    if (index >= 0 && index < tasks.Count)
                    {
                        tasks.RemoveAt(index);
                        Console.WriteLine("Task removed.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid task number.");
                    }
                    break;

                case "4":
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        } while (input != "4");
    }
}
