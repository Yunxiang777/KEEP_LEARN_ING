using System;

class Program
{
    static void Main()
    {
        int[] arr = { 22, 43, 12, 45, 32, 98, 54, 74, 51 };

        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];      // 目前要插入的元素
            int j = i - 1;

            // 往前掃描已排序的子陣列，將比 key 大的元素往後移
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            // 將 key 插入正確位置
            arr[j + 1] = key;
        }

        // 印出排序結果
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}
