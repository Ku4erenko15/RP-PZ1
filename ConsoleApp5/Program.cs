using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = "Zdarova bro, uletau na Gaity";
            int lowercaseCount = 0;
            foreach (char c in content)
            {
                if (char.IsLower(c))
                {
                    lowercaseCount++;
                }
            }
            Console.WriteLine($"Количество строчных букв: {lowercaseCount}");
            Console.ReadKey();
        }
    }

}


