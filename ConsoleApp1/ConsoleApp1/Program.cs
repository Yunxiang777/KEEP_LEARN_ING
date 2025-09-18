using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        upateArray(arr);
        Console.WriteLine(string.Join(", ", arr));
    }

    static void upateArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] += 5;
        }
    }
}
