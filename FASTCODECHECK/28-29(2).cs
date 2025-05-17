using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_29_2_
{
    class Program
    {
        static void Main()
        {
            int[] array = { 64, 25, 12, 22, 11 };
            Console.WriteLine("Исходный массив:");
            PrintArray(array);
            SelectionSortDescending(array);
            Console.WriteLine("Отсортированный массив (по убыванию):");
            PrintArray(array);
        }
        static void SelectionSortDescending(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] > arr[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                if (maxIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[maxIndex];
                    arr[maxIndex] = temp;
                }
            }
        }
        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}