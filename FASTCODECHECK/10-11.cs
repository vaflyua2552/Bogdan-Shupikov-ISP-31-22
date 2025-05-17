using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_11
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Введите координаты вершин четырехугольника:");
            Console.Write("x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("x3: ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y3: ");
            double y3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("x4: ");
            double x4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y4: ");
            double y4 = Convert.ToDouble(Console.ReadLine());

            double centerX = (x1 + x2 + x3 + x4) / 4;
            double centerY = (y1 + y2 + y3 + y4) / 4;

            Console.WriteLine($"Координаты центра четырехугольника: ({centerX}, {centerY})");
        }
    }
}


