using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umnajenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("a * b =  ");
            double ab = Convert.ToDouble(Console.ReadLine());
            if ((a * b)== ab)
                Console.WriteLine("true");
           else
                Console.WriteLine("false");
           Console.ReadLine();

        }
    }
}
