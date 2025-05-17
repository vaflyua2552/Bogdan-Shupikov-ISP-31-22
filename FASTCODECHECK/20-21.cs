using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int max = FindMax(numbers);

        Console.WriteLine("Максимальное значение: " + max);
    }

    static int FindMax(int[] array)
    {
        int max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max;
    }
}

