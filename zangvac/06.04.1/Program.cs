using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._04._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for n.");

            int number = int.Parse(Console.ReadLine()); int[] myarr1 = new int[5] { 54, 23, 25, 47, 1 };

            int[] myarr2 = new int[4] { 23, 4, 25, 7 }; bool res = Equal(myarr1, myarr2, number); Console.WriteLine(res);

            Console.ReadLine();

        }
        static bool Equal(int[] array0, int[] array1, int n)

        {
            if (array0[n] == array1[n])

            {

                return true;

            }



            return false;

        }
    }
    
}
