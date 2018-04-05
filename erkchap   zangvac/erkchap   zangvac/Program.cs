using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erkchap___zangvac
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {

                    Console.Write((i + 1) * (j + 1) + "\t");
                }
                Console.WriteLine();
            }

            ///////////////////////////////////////////////////


            //int[,] arr =
            //{
            //    {1,2,3,4,5 },
            //    {7,8,9,4,5 },
            //    {4,5,6,3,2 },
            //    {4,1,2,3,5 },
            //    {4,8,9,6,3 },

            //};

            //Console.Write("k=");
            //int k = int.Parse(Console.ReadLine());

            //int a = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //       if (arr[i,j]%k==0 & j<i)
            //        {
            //            a++;

            //        }

            //    }

            //}
            //Console.Write(a);

            /////////////////////////////////////////////

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if ((i + j) % 2 == 0)
            //        {
            //            Console.Write(1 + "\t");
            //        }
            //        else
            //        {
            //            Console.Write(0 + "\t");
            //        }

            //    }
            //    Console.WriteLine();
            //}

            Console.ReadLine();
        }
    }
}
