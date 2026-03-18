namespace ConsoleApp22
{
    using System;
    using System.Collections.Generic;

    namespace TodoListApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                List<string> tasks = new List<string>();
                bool running = true;

                while (running)
                {
                    Console.WriteLine("\nTo-Do List Manager");
                    Console.WriteLine("1. Add Task");
                    Console.WriteLine("2. View Tasks");
                    Console.WriteLine("3. Remove Task");
                    Console.WriteLine("4. Exit");
                    Console.Write("Choose an option: ");

                    string input = Console.ReadLine();
                    int choice;

                    if (!int.TryParse(input, out choice))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        continue;
                    }

                    switch (choice)
                    {
                        case 1:
                            // Add Task
                            Console.Write("Enter task: ");
                            string task = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(task))
                            {
                                Console.WriteLine("Task cannot be empty.");
                            }
                            else
                            {
                                tasks.Add(task);
                                Console.WriteLine("Task added!");
                            }
                            break;

                        case 2:
                            // View Tasks
                            if (tasks.Count == 0)
                            {
                                Console.WriteLine("No tasks available.");
                            }
                            else
                            {
                                Console.WriteLine("Tasks:");
                                for (int i = 0; i < tasks.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                                }
                            }
                            break;

                        case 3:
                            // Remove Task
                            if (tasks.Count == 0)
                            {
                                Console.WriteLine("No tasks to remove.");
                                break;
                            }

                            Console.Write("Enter task number to remove: ");
                            string removeInput = Console.ReadLine();
                            int taskNumber;

                            if (!int.TryParse(removeInput, out taskNumber))
                            {
                                Console.WriteLine("Invalid input. Please enter a number.");
                            }
                            else if (taskNumber < 1 || taskNumber > tasks.Count)
                            {
                                Console.WriteLine("Invalid task number.");
                            }
                            else
                            {
                                string removedTask = tasks[taskNumber - 1];
                                tasks.RemoveAt(taskNumber - 1);
                                Console.WriteLine($"Removed: {removedTask}");
                            }
                            break;

                        case 4:
                            // Exit
                            running = false;
                            Console.WriteLine("Exiting application...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please select 1-4.");
                            break;
                    }
                }
            }
        }
    }
}
