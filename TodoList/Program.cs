using System;
using System.Collections.Generic;

namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();
            string command;

            do
            {
                Console.WriteLine("Введите команду (add/view/remove/assign/exit):");
                command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "add":
                        Console.WriteLine("Введите задачу:");
                        string taskDescription = Console.ReadLine();
                        tasks.Add(new Task(taskDescription));
                        Console.WriteLine($"Задача '{taskDescription}' добавлена.");
                        break;

                    case "view":
                        Console.WriteLine("Список задач:");
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("Нет задач.");
                        }
                        else
                        {
                            for (int i = 0; i < tasks.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {tasks[i].Description} (Назначен: {tasks[i].AssignedEmployee})");
                            }
                        }
                        break;

                    case "remove":
                        Console.WriteLine("Введите номер задачи для удаления:");
                        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
                        {
                            string removedTask = tasks[index - 1].Description;
                            tasks.RemoveAt(index - 1);
                            Console.WriteLine($"Задача '{removedTask}' удалена.");
                        }
                        else
                        {
                            Console.WriteLine("Неверный номер задачи.");
                        }
                        break;

                    case "assign":
                        Console.WriteLine("Введите номер задачи для назначения:");
                        if (int.TryParse(Console.ReadLine(), out int taskIndex) && taskIndex > 0 && taskIndex <= tasks.Count)
                        {
                            Console.WriteLine("Введите имя сотрудника:");
                            string employeeName = Console.ReadLine();
                            tasks[taskIndex - 1].AssignedEmployee = employeeName;
                            Console.WriteLine($"Сотрудник '{employeeName}' назначен на задачу '{tasks[taskIndex - 1].Description}'.");
                        }
                        else
                        {
                            Console.WriteLine("Неверный номер задачи.");
                        }
                        break;

                    case "exit":
                        Console.WriteLine("Выход из программы.");
                        break;

                    default:
                        Console.WriteLine("Неизвестная команда.");
                        break;
                }

            } while (command != "exit");
        }

        class Task
        {
            public string Description { get; set; }
            public string AssignedEmployee { get; set; } = "Не назначен";

            public Task(string description)
            {
                Description = description;
            }
        }
    }
}
