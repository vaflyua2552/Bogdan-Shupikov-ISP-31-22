using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();
            Console.WriteLine(" символ для замены:");
            char oldChar = Console.ReadLine()[0];
            Console.WriteLine(" символ  который нужно заменить:");
            char newChar = Console.ReadLine()[0];
            string result = input.Replace(oldChar, newChar);
            Console.WriteLine("Результат: " + result);
        }
    }
}