using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zangvac
{
    class Program
    {
        static void Main(string[] args)
        {

            ////////int[] intArray = new int[5];

            ////////for (int i = 1; i < 5; i++)

            ////////{

            ////////    Console.Write(i+"- ");

            ////////    int n = int.Parse(Console.ReadLine());        
            ////////    intArray[i] = n;         
            ////////    Console.WriteLine($");

            ////////}   

            //int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };  
            //for (int i = 0; i < intArray.length; i++)

            //{

            //    Console.WriteLine("{0}", intArray[i]);

            //}


            //int[] intArray = { 10, 20, 30, 4, 55, 67, 7, 8, 9, 17 };
            //Console.Write("a=");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("b=");
            //int n1 = int.Parse(Console.ReadLine());
            //int a = 0;
            //int b = 0;
            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    if (intArray[i] % n == 0)
            //    {
            //        a++;
            //    }
            //    if (intArray[i] % n1 == 0)

            //    {
            //        b++;
            //    }
            //}
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //int[] intArray = { 10, 20, 30, 4, 55, 67, 7, 8, 9, 17 };

            Console.WriteLine("Enter your favourite 3 numbers");

            int num = int.Parse(Console.ReadLine());

            int num1 = int.Parse(Console.ReadLine());

            int num2 = int.Parse(Console.ReadLine());

            int[] iarray = new int[3] { num, num1, num2 };

            for (int i = 0; i < iarray.Length; i++)
            {

                Console.WriteLine($"{i + 1} {iarray[i]}");

            }


            Console.ReadLine();

        }

    }
    
}
