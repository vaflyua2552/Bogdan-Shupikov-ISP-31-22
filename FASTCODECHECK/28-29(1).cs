using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_29
{
    class Program
    {
        static void Main()
        {
            int[] array = { 64, 25, 12, 22, 11 };
            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            SelectionSortAscending(array);

            Console.WriteLine("Отсортированный массив (по возрастанию):");
            PrintArray(array);
        }

        static void SelectionSortAscending(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
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
