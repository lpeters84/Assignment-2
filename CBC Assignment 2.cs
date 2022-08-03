using System;

class Program
{
    public static int Main(string[] args)
    {
        int n = 5;
        int[] falcon = { 0, 1, 2, 3, 4 };

        int m = 100;
        int[] bar = new int[100];

        for (int i = 0; i < m; i++)
        {
            bar[i] = i;
        }

        Console.WriteLine($"the total number of even numbers in falcon are: {CountEvenNum(falcon, n)}");
        Console.WriteLine($"the total number of even numbers in bar are: {CountEvenNum(bar, m)}");

        return 0;

    }

    static int CountEvenNum(int[] arr, int size)
    {
        int count = 0;
        int j;

        for (j = 0; j < size; j++)
        {
            if (arr[j] % 2 == 0)
            {
                count++;
            }

        }
        return count;
    }
}
