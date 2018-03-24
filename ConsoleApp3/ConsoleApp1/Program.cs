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

            DateTime d = DateTime.Now;
            Console.WriteLine(d.Date);   //amsativ
            Console.WriteLine(d.Day);  //amsva   or
            Console.WriteLine(d.DayOfWeek);  //shabatva  or
            Console.WriteLine(d.DayOfYear);  //tarva  or
            Console.WriteLine(d.TimeOfDay);  //jam
            Console.WriteLine(d.ToString());
            Console.WriteLine(d.ToUniversalTime());
            Console.ReadLine();
        }
    }
}
