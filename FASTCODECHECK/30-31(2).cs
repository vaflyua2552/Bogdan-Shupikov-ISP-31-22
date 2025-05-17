using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_31_2_
{
    class Program
    {
        static void Main()
        {
            int[] array = { 5, 3, 8, 1, 2 };

            Array.Sort(array);
            Array.Reverse(array);

            Console.WriteLine("Массив отсортирован по убыванию:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}

