using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_55
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter("numbers.txt"))
            {
                for (int i = 1; i <= 256; i++)
                {
                    writer.Write(i);
                    if (i < 256) writer.Write(",");
                }
            }
            string[] carBrands = { "Toyota", "Ford", "Chevrolet", "Honda", "Nissan", "BMW", "Mercedes-Benz", "Audi", "Volkswagen", "Hyundai", "Kia" };
            using (StreamWriter writer = new StreamWriter("car_brands.txt"))
            {
                foreach (var brand in carBrands)
                {
                    writer.WriteLine(brand);
                }
            }
            string filename = "car_brands.txt";
            int maxLength = 0;
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    maxLength = Math.Max(maxLength, line.Length);
                }
            }
            Console.WriteLine("Длина самой длинной строки: " + maxLength);
            Random random = new Random();
            int N = 20;
            int[] numbers = new int[N];

            for (int i = 0; i < N; i++)
            {
                numbers[i] = random.Next(1, 1000);
            }

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < N; i += 2)
                {
                    writer.Write(numbers[i] + (i + 2 < N ? ", " : ""));
                }
                writer.WriteLine();
                for (int i = 1; i < N; i += 2)
                {
                    writer.Write(numbers[i] + (i + 2 < N ? ", " : ""));
                }
            }

            Console.WriteLine("Результаты записаны в файл output.txt");
        }
    }
}