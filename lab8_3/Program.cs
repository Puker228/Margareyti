using System;
using lab8_3;

class Program
{
    static void Main()
    {
        Triangle myTriangle = new Triangle(3, 4, 5, 1, 1, 1, 1, 1, 1);

        Console.WriteLine($"Сторона A: {myTriangle.SideA}");
        Console.WriteLine($"Сторона B: {myTriangle.SideB}");
        Console.WriteLine($"Сторона C: {myTriangle.SideC}");

        myTriangle.Move(1, 1);
        Console.WriteLine("\nТреугольник перемещен");
        Console.WriteLine($"Новые координаты: ({myTriangle.X1}, {myTriangle.Y1}); " +
                                            $"({myTriangle.X2}, {myTriangle.Y2}); " +
                                            $"({myTriangle.X3}, {myTriangle.Y3})");

        myTriangle.Resize(1.5);
        Console.WriteLine("\nТреугольник изменен в размере");
        Console.WriteLine($"Новый размер: \na = {myTriangle.SideA} " +
                                        $"\nb = {myTriangle.SideB} " +
                                        $"\nc = {myTriangle.SideC}");

        myTriangle.Rotate(45);
        Console.WriteLine("\nТреугольник повернут");
        Console.WriteLine($"Новые координаты: ({myTriangle.X1}, {myTriangle.Y1}); " +
                          $"({myTriangle.X2}, {myTriangle.Y2}); " +
                          $"({myTriangle.X3}, {myTriangle.Y3})");

    }
}
