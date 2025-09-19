using System;

class Program
{
    static void Main()
    {
        Point p1 = new Point(3, 5);
        Point p2 = new Point(2, 7);

        // 使用重載的 + 運算符
        Point sum = p1 + p2;
        Console.WriteLine(sum); // 輸出: (5, 12)

        // 使用重載的 - 運算符
        Point diff = p1 - p2;
        Console.WriteLine(diff); // 輸出: (1, -2)
    }
}

// 定義 Point 類別
public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // 重載 + 運算符
    public static Point operator +(Point a, Point b)
    {
        return new Point(a.X + b.X, a.Y + b.Y);
    }

    // 重載 - 運算符
    public static Point operator -(Point a, Point b)
    {
        return new Point(a.X - b.X, a.Y - b.Y);
    }

    // 重載 ToString() 方便輸出
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
