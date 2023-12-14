namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double uvel, ugol, x, y, down, left, right, up;
 
            Console.Write("Введите значение x0 для точки А: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение y0 для точки А: ");
            y = Convert.ToDouble(Console.ReadLine());
            Point a = new Point(x, y);
 
            Console.Write("Введите значение x0 для точки В: ");
            x = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите значение y0 для точки В: ");
            y = Convert.ToSingle(Console.ReadLine());
            Point b = new Point(x, y);
            
            Console.Write("Введите значение x0 для точки C: ");
            x = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите значение y0 для точки C: ");
            y = Convert.ToSingle(Console.ReadLine());
            Point c = new Point(x, y);
            
            Console.WriteLine();
            Triangle T = new Triangle(a, b, c);
            T.Coordinates();
            
            Console.Write("\nСдвиг вниз: ");
            down = Convert.ToSingle(Console.ReadLine());
            T.sdvig_down(down);
            T.Coordinates();
            
            Console.Write("\nCдвиг влево: ");
            left = Convert.ToSingle(Console.ReadLine());
            T.sdvig_left(left);
            T.Coordinates();
            
            Console.Write("\nСдвиг вправо: ");
            right = Convert.ToSingle(Console.ReadLine());
            T.sdvig_right(right);
            T.Coordinates();
            
            Console.Write("\nСдвиг вверх: ");
            up = Convert.ToSingle(Console.ReadLine());
            T.sdvig_up(up);
            T.Coordinates();
            
            Console.Write("\nУвеличение на: ");
            uvel = Convert.ToSingle(Console.ReadLine());
            T.sdvig_rad(uvel);
 
            T.Coordinates();
            Console.Write("\nВведите угол вращения d: ");
            ugol = Convert.ToSingle(Console.ReadLine());
 
            T.sdvig_alfa(ugol);
            T.Coordinates();
 
        }
    }
}
 
 class Point 
 {
    public double x0, y0, x1, y1, x2, y2;
    public Point(double x, double y)
    {
        x0 = x;
        y0 = y;
        x1 = x;
        y1 = y;
        x2 = x;
        y2 = y;
    }
}
 
class Triangle
{
    public Point a { set; get; }
    public Point b { set; get; }
    public Point c { set; get; }
    
    public Triangle(Point _a, Point _b, Point _c)   
    {
        this.a = _a; 
        this.b = _b;
        this.c = _c;
    }
    
    public void sdvig_right(double right)   
    {
        a.x0 =a.x0 +right;
        b.x1 = b.x1 + right;
        c.x2 = c.x2 + right;

    }
    public void sdvig_left(double left)    
    {
        a.x0 = a.x0-left;
        b.x1 = b.x1 - left;
        c.x2 = c.x2 - left;
    }
    public void sdvig_up(double up)  
    {
        a.y0 =a.y0 +up;
        b.y1 = b.y1 + up;
        c.y2 = c.y2 + up;
    }
    public void sdvig_down(double down)    
    {
        a.y0 = a.y0-down;
        b.y1 = b.y1 - down;
        c.y2 = c.y2 - down;
    }
    public double Rotate(Point _a, Point _b)
    {
        return Convert.ToSingle(Math.Sqrt(Math.Pow(_a.x0 - _b.x1, 2) + Math.Pow(_a.y0 - _b.y1, 2)));
    }
   public void sdvig_alfa(double ugol)    
    {
        Point M = new Point((a.x0+b.x1+c.x2)/3,(a.y0+b.y1+c.y2)/3);
        a.x0 = M.x0 + Convert.ToSingle(Rotate(M,a) * Math.Cos(ugol));
        a.y0 = M.y0 - Convert.ToSingle(Rotate(M, a) * Math.Sin(ugol));
        b.x1 = M.x1 + Convert.ToSingle(Rotate(M, b) * Math.Cos(ugol));
        b.y1 = M.y1 - Convert.ToSingle(Rotate(M, b) * Math.Sin(ugol));
        c.x2 = M.x2 + Convert.ToSingle(Rotate(M, c) * Math.Cos(ugol));
        c.x2 = M.x2 - Convert.ToSingle(Rotate(M, c) * Math.Sin(ugol));
    }
    public void sdvig_rad(double uvel) 
    {
        a.x0 += uvel;
        a.y0 += uvel;
        
        b.x1 += uvel;
        b.y1 += uvel;
        
        c.x2 += uvel;
        c.y2 += uvel;
    }

    public void Coordinates() 
    {
        Console.WriteLine("a(x,y)={0},{1}\nb(x,y)={2},{3}\nc(x,y)={4},{5}", a.x0, a.y0,b.x1,b.y1,c.x2,c.y2);
    }
}