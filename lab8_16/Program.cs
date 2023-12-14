using System;

namespace lab8_16
{
    class Program
    {
        static void Main()
        {
            Console.Write("Длина комнаты(м) - ");
            int len = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Ширина комнаты(м) - ");
            int wid = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Высота комнаты(м) - ");
            int hei = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Кол-во окон - ");
            int win = Convert.ToInt32(Console.ReadLine());
            
            Room room228 = new Room(len, wid, hei, win);
            int vol = room228.Volume();
            int area = room228.Area();
            
            
            Console.WriteLine("1 - Площадь комнаты");
            Console.WriteLine("2 - Объем комнаты");
            Console.WriteLine("3 - Хар-и комнаты");
            
            Console.Write("Выбор: ");
            int choiceSw = Convert.ToInt32(Console.ReadLine());
            switch (choiceSw)
            {
                case 1:
                    Console.WriteLine($"Площадь равна {area} м2");
                    break;
                case 2:
                    Console.WriteLine($"Объем равен {vol} м3");
                    break;
                case 3:
                    Console.WriteLine($"\nДлина - {room228.Len} м\nШирина - {room228.Wid} м\nВысота - {room228.Hei} м\nКол-во окон - {room228.Win} шт");
                    break;
            }
        }
    }
}