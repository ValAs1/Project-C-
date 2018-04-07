using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._04._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for x.");

            int x = int.Parse(Console.ReadLine());

            bool tr = Ret(new int[5] { 14, 23, 61, 5, 9 }, x);

            Console.WriteLine(tr);

            Console.ReadLine();



        }

        static bool Ret(int[] array1, int x)

        {

            for (int i = 0; i < array1.Length; i++)

            {

                if (x == array1[i])

                {

                    return true;

                }

            }
            return false;



        }
    }
    }
}
