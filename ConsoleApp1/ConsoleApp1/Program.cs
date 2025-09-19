using System;

class Program
{
    static void Main()
    {
        string myString = "hello world";

        // 使用擴充方法
        string result = myString.FirstUpper();

        Console.WriteLine(result); // 輸出: Hello world
    }
}

// 靜態類別放擴充方法
public static class Tool
{
    // 擴充方法語法：this string input
    public static string FirstUpper(this string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        return char.ToUpper(input[0]) + input.Substring(1);
    }
}
