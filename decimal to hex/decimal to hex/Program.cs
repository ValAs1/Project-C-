using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimal_to_hex
{
    class Program
    {
        static void Main()
        {
            int i;
            i = Convert.ToInt32(Console.ReadLine());
            //try
            //{
            //    i = Convert.ToInt32(Console.ReadLine());
            //}
            //catch
            //{
            //    Console.WriteLine("vvidite  chislii");
            //    i = 0;
            //}


            //if (i==1 || i==2 || i==3 || i==5 || i==7 )
            //    Console.WriteLine("prastoy  cheslo -  " + i);
            //else 
            if (i % 10 >= 0)
                Console.WriteLine("i/2 -  " + i);
            else
                
                    Console.WriteLine("i<2 -  " + i);

            //else if (i % 3 == 0)
            //    Console.WriteLine("i/3 -  " + i);
            //else if (i % 5 == 0)
            //    Console.WriteLine("i/5 -  " + i);
            //else if (i % 7 == 0)
            //    Console.WriteLine("i/7 -  " + i);
            //else
            //    Console.WriteLine("prastoy  cheslo -  "+i);



            Console.ReadLine();

        }
    }
}
