using System;

class MyClass
{
    // 宣告私有欄位
    private int number;

    // 公開屬性（property）提供 get 與 set 方法
    public int Number
    {
        get { return number; }      // 讀取值
        set { number = value; }     // 設定值
    }
}

class Program
{
    static void Main()
    {
        MyClass obj = new MyClass();

        // 使用 set 設定值
        obj.Number = 42;

        // 使用 get 取得值
        Console.WriteLine(obj.Number);  // 輸出 42
    }
}
