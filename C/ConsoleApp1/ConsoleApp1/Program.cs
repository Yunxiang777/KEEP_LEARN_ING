

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 4, 5 };
        var query = from n in nums
                    where n % 2 == 0
                    select n * n;
        foreach (var item in query)
        {
            Console.WriteLine(item);
        }
    }
}

