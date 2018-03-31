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
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            int[] Array = new int[n];

            for (int i = 0; i <= n; i++)
            {
                Array[i] =i*i;
                // Array[i] = i * i;
                Console.Write(Array[i] + ", ");
            }
            Console.ReadLine();
        }
    }
}
