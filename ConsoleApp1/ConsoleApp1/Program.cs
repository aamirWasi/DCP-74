using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 3; i++)
            {
                if (i % 2 == 0)
                {
                    i *= 3;
                }
                for (j = 1; j <= 3; j++)
                {
                    Console.Write($"{i} ");
                    i--;
                }
                Console.WriteLine();
            }
        }
    }
}