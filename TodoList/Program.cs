<<<<<<< HEAD
﻿using System;
=======
using System;
>>>>>>> 6fdd7a5c26eea2a127397e3a97d74aa93e0cede5
using System.Collections.Generic;

namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();
            string command;

<<<<<<< HEAD
            Console.WriteLine("Добро пожаловать в Todo List!");
            do
            {
                Console.WriteLine("Введите команду (add/show/exit):");
                command = Console.ReadLine();

                if (command == "add")
                {
                    Console.WriteLine("Введите задачу:");
                    string task = Console.ReadLine();
                    tasks.Add(task);
                    Console.WriteLine("Задача добавлена.check");
                }
                else if (command == "show")
                {
                    Console.WriteLine("Ваши задачи:");
                    foreach (var t in tasks)
                    {
                        Console.WriteLine(t);
                    }
=======
            do
            {
                Console.WriteLine("Введите команду (add/view/remove/exit):");
                command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "add":
                        Console.WriteLine("Введите задачу:");
                        string task = Console.ReadLine();
                        tasks.Add(task);
                        Console.WriteLine($"Задача '{task}' добавлена.");
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
                                Console.WriteLine($"{i + 1}. {tasks[i]}");
                            }
                        }
                        break;

                    case "remove":
                        Console.WriteLine("Введите номер задачи для удаления:");
                        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
                        {
                            string removedTask = tasks[index - 1];
                            tasks.RemoveAt(index - 1);
                            Console.WriteLine($"Задача '{removedTask}' удалена.");
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
>>>>>>> 6fdd7a5c26eea2a127397e3a97d74aa93e0cede5
                }

            } while (command != "exit");
        }
    }
}
