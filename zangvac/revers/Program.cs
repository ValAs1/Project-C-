using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Գրել ծրագիր, որը կհակադարձի զանգվածը։


            Console.WriteLine("nermucel zangvaci  tareri  qanak@");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("nermucel  zangvaci  tarer@");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array   zangvac@");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int a = array[j];
                        array[j] = array[i];
                        array[i] = a;
                    }
                }

            }

            //Array.Reverse(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }

            //double[] NewArray = new double[Array.Length];
            //for (int i = 0; i < Array.Length; i++)
            //{
            //    NewArray[i] = Array[i];
            //}
            //Console.WriteLine("\nNewArray   zangvac@");
            //for (int i = 0; i < NewArray.Length; i++)
            //{
            //    Console.Write(NewArray[i] + ", ");
            //}
            Console.ReadLine();
        }
    }
}
