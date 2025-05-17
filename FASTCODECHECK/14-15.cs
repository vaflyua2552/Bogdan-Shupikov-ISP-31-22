using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов массива: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[N];
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        List<int> positiveIndices = new List<int>();
        double sum = 0;
        int count = 0;
        for (int i = 0; i < N; i++)
        {
            if (array[i] > 0)
            {
                positiveIndices.Add(i);
                sum += array[i];
                count++;
            }
        }
        if (count > 0)
        {
            double average = sum / count;
            Console.WriteLine($"Среднее арифметическое среди положительных элементов: {average}");

            Console.WriteLine("Индексы, соответствующие среднему арифметическому:");
            for (int i = 0; i < positiveIndices.Count; i++)
            {
                if (array[positiveIndices[i]] == average)
                {
                    Console.WriteLine(positiveIndices[i]);
                }
            }
        }
        else
        {
            Console.WriteLine("Нет положительных элементов в массиве.");
        }
    }
}

