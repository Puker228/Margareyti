namespace lab8_16;

public class Room
{
    // поля
    private int length;
    private int width;
    private int height;
    private int windows;
    
    
    // конструктор
    public Room(int length, int width, int height, int windows)
    {
        if (length <= 0 || windows < 0 || width <= 0 || height <= 0)
        {
            throw new ArgumentException("Неправильно введенные значения");
        }
        else
        {
            this.length = length;
            this.width = width;
            this.height = height;
            this.windows = windows;
        }
    }
    
    
    // методы
    public int Area()
    {
        int area = length * width;
        return area;
    }
    
    public int Volume()
    {
        int vol = length * width * height;
        return vol;
    }
    
    
    // свойства
    public int Len
    {
        get { return length; }
    }

    public int Wid
    {
        get { return width; }
    }

    public int Win
    {
        get { return windows; }
    }

    public int Hei
    {
        get { return height; }
    }
}