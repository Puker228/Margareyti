﻿using System;
using System.Net.Sockets;

namespace Prak4_1
{
    class Program
    {
        static void Main()
        {
            List<int> list = new List<int>();
            
            while (true)
            {
                Console.WriteLine("Выберите дейстивие:");
                Console.WriteLine("1 - Создать список");
                Console.WriteLine("2 - Добавить элемент в конец списка");
                Console.WriteLine("3 - Добавить элемент в список");
                Console.WriteLine("4 - Удалить элемент из списка");
                Console.WriteLine("5 - Вывести список");
                Console.WriteLine("6 - Удалить список");
                Console.WriteLine("7 - Выйти");
                Console.Write("Действие: ");
                string choiceSw = Console.ReadLine();
                switch (choiceSw)
                {
                    case "1":
                        Console.Write("Количество элементов в списке: ");
                        int len = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= len; i++)
                        {
                            Console.Write($"\nЗначение: ");
                            list.Add(Convert.ToInt32(Console.ReadLine()));
                        }
                        Console.WriteLine("\nСоздан новый список");
                        break;
                    case "2":
                        Console.Write("Значение: ");
                        int New= Convert.ToInt32(Console.ReadLine());
                        list.Add(New); 
                        Console.WriteLine("\nСписок изменен");
                        break;
                    case "3":
                        Console.Write("Номер элемента: ");
                        New = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.Write("Значение: ");
                        list.Insert(New, Convert.ToInt32(Console.ReadLine())); 
                        Console.WriteLine("\nСписок изменен");
                        break;
                    case "4":
                        Console.Write("Номер элемента: ");
                        int Del = Convert.ToInt32(Console.ReadLine()) - 1;
                        list.RemoveAt(Del);
                        Console.WriteLine("\nЭлемент удален");
                        break;
                    case "5":
                        foreach (var i in list)
                        {
                            Console.Write($"{i} ");
                        }
                        Console.WriteLine();
                        break;
                    case "6":
                        list.Clear();
                        Console.WriteLine("\nСписок обнулен");
                        break;
                    case "7":
                        return;
                }
            }
        }
    }
}