using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_61
{
    class Program
    {
        public delegate int NextNumberDelegate();

        static void Main(string[] args)
        {
            Console.WriteLine("Арифметическая прогрессия:");
            GenerateSequence(ArithmeticProgression(5, 3), 10);
            Console.WriteLine("\nГеометрическая прогрессия:");
            GenerateSequence(GeometricProgression(2, 3), 10);
            Console.WriteLine("\nПоследовательность Фибоначчи:");
            GenerateSequence(FibonacciSequence(), 10);
        }
        static void GenerateSequence(NextNumberDelegate nextNumber, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(nextNumber() + " ");
            }
            Console.WriteLine();
        }
        static NextNumberDelegate ArithmeticProgression(int start, int step)
        {
            int current = start;
            return () =>
            {
                int result = current;
                current += step;
                return result;
            };
        }
        static NextNumberDelegate GeometricProgression(int start, int multiplier)
        {
            int current = start;
            return () =>
            {
                int result = current;
                current *= multiplier;
                return result;
            };
        }
        static NextNumberDelegate FibonacciSequence()
        {
            int a = 0, b = 1;
            return () =>
            {
                int result = a;
                int temp = a;
                a = b; b = temp + b;
                return result;
            };
        }
    }

}