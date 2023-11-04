using System;
using System.Linq;

class Program
{
    static void Main()
    {     
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int N = int.Parse(Console.ReadLine());
        double sum = 0;
        int count = 0;

        for (int i = numbers.Length - 1; i >= 0 && count < N; i--)
        {
            sum += numbers[i];
            count++;
        }
        double average = sum / count;

        Console.WriteLine($"{average:F2}");
    }
}
