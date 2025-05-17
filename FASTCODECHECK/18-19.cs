using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число n: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 1)
        {
            Console.WriteLine("Введите натуральное число больше 0.");
            return;
        }

        int k = 0;
        while (Math.Pow(2, k) < n)
        {
            k++;
        }

        Console.WriteLine($"Наименьшее целое k, такое что 2^k >= {n}: {k}");
    }
}

