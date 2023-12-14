using System;

namespace prak4_2
{
    class Program
    {
        static void Main()
        {
            LList list = null;
            Console.WriteLine("1 - Создать список");
            Console.WriteLine("2 - Добавить в конец списка");
            Console.WriteLine("3 - Добавить в список");
            Console.WriteLine("4 - Удалить элемент из списка");
            Console.WriteLine("5 - Вывести список");
            Console.WriteLine("6 - Удалить список");
            Console.WriteLine("7 - Выйти");
            Console.Write("Действие: ");
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1:
                    list = new LList();
                    list.AddList();
                    Console.WriteLine("Список создан");
                    break;
                case 2:
                    Console.Write("Новые данные: ");
                    int data = Convert.ToInt32(Console.ReadLine());
                    list.AddData(data);
                    break;
                case 3:
                    Console.Write("Новые данные: ");
                    int insertData = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Позиция: ");
                    int position = Convert.ToInt32(Console.ReadLine());
                    list.InsertPos(insertData, position);
                    break;
                case 4:
                    Console.Write("Позиция: ");
                    int deletePosition = Convert.ToInt32(Console.ReadLine());
                    list.DelData(deletePosition);
                    break;
                case 5:
                    list.ReadData();
                    break;
                case 6:
                    list = null;
                    Console.WriteLine("Список обнулен");
                    break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Нет такого выбора");
                    break;
            }
        }
    }
}