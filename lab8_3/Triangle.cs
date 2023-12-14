using System;

namespace lab8_3;
public class Triangle
{
    private double sideA;
    private double sideB;
    private double sideC;

    private double x1, y1;
    private double x2, y2;
    private double x3, y3;

    // Конструктор 
    public Triangle(double a, double b, double c, double x1, double y1, double x2, double y2, double x3, double y3)
    {
        if (!Valid(a, b, c))
        {
            throw new ArgumentException("Невозможно создать треугольник с данными сторонами.");
        }
        else
        {
            sideA = a;
            sideB = b;
            sideC = c;
            
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            
        }
    }

    // Методы
    private bool Valid(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
    
    public void Move(double deltaX, double deltaY)
    {
        x1 += deltaX;
        y1 += deltaY;
        
        x2 += deltaX;
        y2 += deltaY;
        
        x3 += deltaX;
        y3 += deltaY;
    }

    public void Resize(double scale)
    {
        sideA *= scale;
        sideB *= scale;
        sideC *= scale;
    }

    public void Rotate(double angleDegrees)
    {
        double angleRadians = angleDegrees * Math.PI / 180.0;
        double cosTheta = Math.Cos(angleRadians);
        double sinTheta = Math.Sin(angleRadians);

        double x1 = sideA * cosTheta - sideB * sinTheta;
        double y1 = sideA * sinTheta + sideB * cosTheta;

        double x2 = sideB * cosTheta - sideC * sinTheta;
        double y2 = sideB * sinTheta + sideC * cosTheta;

        double x3 = sideC * cosTheta - sideA * sinTheta;
        double y3 = sideC * sinTheta + sideA * cosTheta;

        sideA = Math.Sqrt(x1 * x1 + y1 * y1);
        sideB = Math.Sqrt(x2 * x2 + y2 * y2);
        sideC = Math.Sqrt(x3 * x3 + y3 * y3);
    }

    // Свойства 
    public double SideA
    {
        get { return sideA; }
    }

    public double SideB
    {
        get { return sideB; }
    }

    public double SideC
    {
        get { return sideC; }
    }
    
    
    public double X1
    {
        get { return x1; }
    }
    
    public double X2
    {
        get { return x2; }
    }
    
    public double X3
    {
        get { return x3; }
    }
    
    public double Y1
    {
        get { return y1; }
    }
    
    public double Y2
    {
        get { return y2; }
    }
    
    public double Y3
    {
        get { return y3; }
    }
}