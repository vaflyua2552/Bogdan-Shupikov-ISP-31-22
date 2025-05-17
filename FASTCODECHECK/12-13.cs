using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты первой точки:");
        Console.Write("x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите координаты второй точки:");
        Console.Write("x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        int quadrant1 = GetQuadrant(x1, y1);

        int quadrant2 = GetQuadrant(x2, y2);

        if (quadrant1 == quadrant2)
        {
            Console.WriteLine("Обе точки лежат в одном и том же квадранте.");
        }
        else
        {
            Console.WriteLine("Точки лежат в разных квадрантах.");
        }
    }

    static int GetQuadrant(double x, double y)
    {
        if (x > 0 && y > 0) return 1;
        if (x < 0 && y > 0) return 2;
        if (x < 0 && y < 0) return 3;
        if (x > 0 && y < 0) return 4;
        return 0;
    }
}


