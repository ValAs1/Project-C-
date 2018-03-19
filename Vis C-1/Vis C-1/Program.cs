using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vis_C_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ValAs");
                      
            string inp = Console.ReadLine();    // input
            int a = int.Parse(inp);
            int b = a + 5;
            Console.WriteLine(b);

            int myInt1;
            myInt1 = 0;

            int myInt2;

            Console.WriteLine($"myInt2: {myInt1}");
            myInt2 = 369;
            Console.WriteLine($"myInt2: {myInt2}");
            int myInt3 = 15;
            Console.WriteLine($"myInt3: {myInt3}");
            double myDouble = 15.8;
            Console.WriteLine($"myDouble: {myDouble}");
            string myString = "Hello world";
            Console.WriteLine(myString);
            string myString1 = "Hello \n world";
            Console.WriteLine(myString1);
            char mychar = 'g';   //  1символ
            Console.WriteLine(mychar);
            var myT1 = "test";
            Console.WriteLine(myT1);

            //int r = 0;
            //while (r <= 12)
            //{
            //    Console.WriteLine(r++);
            //}

            int r = 0;
            do
            {
                Console.WriteLine(r);
            }
            while (++r <= 12);
            Console.ReadLine();
        }
    }
}
