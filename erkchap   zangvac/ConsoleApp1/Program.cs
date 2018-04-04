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
            Console.WriteLine("Enter a number for n");
            int n = int.Parse(Console.ReadLine());

            int num = 0;
            int[,] array1 =
            {
               { 15, 25, 31, 2, 14 },
               { 41, 12, 81, 32, 6, },
               { 15, 29, 41, 4, 71 },
               { 30, 91, 5, 4, 21},
               { 25, 10, 64, 48, 3, }
           };
            for (int i = 0; i < 5; i++)
            {
                for (int y = 0; y < 5; y++)
                {
                    if (array1[i, y] % n == 0 & y < i)
                    {
                        num++;
                    }
                }
            }
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
