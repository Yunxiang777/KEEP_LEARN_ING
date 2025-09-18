using System;

class Person   // 這是一個非靜態類 (instance class)
{
    public string Name;   // 每個物件有自己的 Name
    public int Age;       // 每個物件有自己的 Age
}

class Program
{
    static void Main()
    {
        // 建立第一個實例
        Person p1 = new Person();
        p1.Name = "Alice";
        p1.Age = 25;

        // 建立第二個實例
        Person p2 = new Person();
        p2.Name = "Bob";
        p2.Age = 30;

        Console.WriteLine($"{p1.Name}, {p1.Age}"); // 輸出: Alice, 25
        Console.WriteLine($"{p2.Name}, {p2.Age}"); // 輸出: Bob, 30
    }
}
