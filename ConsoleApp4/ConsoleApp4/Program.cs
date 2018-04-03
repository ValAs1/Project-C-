using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            private string hash(string text)
            {
                byte[] data = Encoding.Default.GetBytes(text);
                var result = new SHA256Managed().ComputeHash(data);
                return BitConverter.ToString(result).Replace("-", "").ToLower();
            }
        }
    }
}
