using System;
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
                Console.WriteLine("1 - Создать список");
                Console.WriteLine("2 - Добавить элемент в конец списка");
                Console.WriteLine("3 - Добавить элемент в список");
                Console.WriteLine("4 - Удалить элемент из списка");
                Console.WriteLine("5 - Вывести список");
                Console.WriteLine("6 - Удалить список");
                Console.WriteLine("7 - Выйти");

                Console.Write("Действие: ");
                string c = Console.ReadLine();
                switch (c)
                {
                    case "1":
                        Console.Write("Количество элементов в списке: ");
                        int listLen = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= listLen; i++)
                        {
                            Console.Write($"\n{i} элемент: ");
                            list.Add(Convert.ToInt32(Console.ReadLine()));
                        }
                        Console.WriteLine("\nСоздан новый список");
                        break;
                    
                    case "2":
                        Console.Write("Новое значение: ");
                        int listNum= Convert.ToInt32(Console.ReadLine());
                        list.Add(listNum); 
                        Console.WriteLine("\nСписок изменен");
                        break;
                    
                    case "3":
                        Console.Write("Номер элемента, на которое вы хотите поместить новое значение: ");
                        listNum = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.Write("Новое значение: ");
                        list.Insert(listNum, Convert.ToInt32(Console.ReadLine())); 
                        Console.WriteLine("\nСписок изменен");
                        break;
                    
                    case "4":
                        Console.Write("Номер элемента, который вы хотите удалить: ");
                        int listDel = Convert.ToInt32(Console.ReadLine()) - 1;
                        list.RemoveAt(listDel);
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