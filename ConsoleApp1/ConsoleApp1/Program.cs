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
            Console.Write("введите трехзначное число ");
            string r = Console.ReadLine();
            int g = int.Parse(r);
            int a = g % 10;
            int b = g - a ;
            int b1 = b % 100;
            //int b = g - a * 100;
            //int b1 = b / 10;
            //int c = b - b1*10;
            Console.WriteLine(a);
            Console.WriteLine(b1);
            //Console.WriteLine(c);
            Console.ReadLine();

        }
    }
}
