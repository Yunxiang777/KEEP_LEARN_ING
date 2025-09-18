using System;

class Program
{
    static void Main()
    {
        int a = 10;
        int b = 20;
        int max = Getmx(a, b);
        Console.WriteLine("Maximum value is: " + max);
    }

    static int Getmx(int a, int b)
    {
        int max = a;
        if (b > max)
        {
            max = b;
        }
        return max;
    }
}
