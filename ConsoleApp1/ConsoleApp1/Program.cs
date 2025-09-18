using System;

class MyClass
{
    // 四個 int 欄位
    public int a;
    public int b;
    public int c;
    public int d;

    // 建構子，用來初始化欄位
    public MyClass(int a, int b, int c, int d)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
    }

    // 方法：計算四個數字的總和
    public int Sum()
    {
        return a + b + c + d;
    }
}

class Program
{
    static void Main()
    {
        // 建立類別物件
        MyClass obj = new MyClass(1, 2, 3, 4);

        // 使用類別的方法
        Console.WriteLine("Sum = " + obj.Sum());  // 輸出 Sum = 10

        // 直接修改欄位
        obj.a = 10;
        Console.WriteLine("New Sum = " + obj.Sum()); // 輸出 New Sum = 19
    }
}
