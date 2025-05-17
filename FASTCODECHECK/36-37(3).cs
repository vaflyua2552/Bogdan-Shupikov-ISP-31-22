using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_37_3_
{
    class Program
    {
        static void Main()
        {
            string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            string randomString = new string(Enumerable.Repeat(characters, 32)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            Console.WriteLine("Случайная строка: " + randomString);
            FindDuplicateCharacters(randomString);
        }
        static void FindDuplicateCharacters(string input)
        {
            HashSet<char> seenCharacters = new HashSet<char>();
            HashSet<char> duplicateCharacters = new HashSet<char>();
            foreach (char c in input)
            {
                if (char.IsLetterOrDigit(c))
                {
                    if (seenCharacters.Contains(c))
                    {
                        duplicateCharacters.Add(c);
                    }
                    else
                    {
                        seenCharacters.Add(c);
                    }
                }
            }
            Console.WriteLine("Повторяющиеся символы: " + string.Join(", ", duplicateCharacters));
        }
    }
}
