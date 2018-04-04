using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int y = 0; y < 5; y++)
                {
                    if ((i + y) % 2 == 0)
                    {
                        array1[i, y] = 1;
                        Console.Write(array1[i, y] + "\t");

                    }
                    else
                    {
                        array1[i, y] = 0;
                        Console.Write(array1[i, y] + "\t"); ;
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
