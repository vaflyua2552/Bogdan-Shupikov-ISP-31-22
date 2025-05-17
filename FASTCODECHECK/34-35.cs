using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение m:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение n:");
            int n = int.Parse(Console.ReadLine());
            long result = Ackermann(m, n);
            Console.WriteLine($"A({m}, {n}) = {result}");
        }
        static long Ackermann(int m, int n)
        {
            if (m == 0)
                return n + 1;
            else if (m == 1)
                return n + 2;
            else if (m == 2)
                return 2 * n + 3;
            else if (m == 3)
                return (1 << (n + 3)) - 3;
            else
                throw new ArgumentOutOfRangeException("Значение m слишком большое");
        }
    }
}