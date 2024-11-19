using System;
using System.Collections.Generic;

namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();
            string command;

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
                    Console.WriteLine("Задача добавлена.");
                }
                else if (command == "show")
                {
                    Console.WriteLine("Ваши задачи:");
                    foreach (var t in tasks)
                    {
                        Console.WriteLine(t);
                    }
                }

            } while (command != "exit");
        }
    }
}
