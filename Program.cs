using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] array = new int[100000];
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 100000);
        }

        StopWatch stopwatch = new StopWatch();
        stopwatch.Start();
        SelectionSort(array);
        stopwatch.Stop();
        double elapsedTime = stopwatch.GetElapsedTime();
        Console.WriteLine("Elapsed time for selection sort: " + elapsedTime + " milliseconds");
    }
    public static void SelectionSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }
}
