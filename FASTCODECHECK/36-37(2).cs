using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_37_2_
{
    class Program
    {
        static void Main()
        {
            string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            string randomString = new string(Enumerable.Repeat(characters, 32)
               .Select(s => s[random.Next(s.Length)]).ToArray());
            Console.WriteLine(randomString);
        }
    }

}
