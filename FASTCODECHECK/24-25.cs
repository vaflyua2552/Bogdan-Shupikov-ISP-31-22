using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_25
{

    class Program

    {

        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int k = 2;

            Console.WriteLine("Исходный массив: " + string.Join(", ", array));
            LeftRotate(array, k);

            Console.WriteLine("Масств после сдвига: " + string.Join(", ", array));

        }

        static void LeftRotate(int[] arr, int k)
        {

            int n = arr.Length;

            k = k % n;

            int[] temp = new int[n];

            for (int i = 0; i < n; i++)
            {
                temp[i] = arr[(i + k) % n];
            }
            for (int i = 0; i < n; i++)
            {
                arr[i] = temp[i];
            }
        }
    }
}