using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program_01
    {
        static void Main(string[] args)
        {
            DateTime d11 = new DateTime(2023, 06, 7);
            Console.WriteLine(d11);

            DateTime d22 = new DateTime(2023, 06, 7, 10, 24, 35);
            Console.WriteLine(d22);
            DateTime today = DateTime.Now;
            Console.WriteLine(today);

            DateTime d3 = today.AddDays(10);
            Console.WriteLine(d3);

            DateTime d1 = new DateTime(2023, 01, 07);
            DateTime d2 = new DateTime(2023, 01, 08);

            TimeSpan diff = d2 - d1;
            Console.WriteLine(diff);

            TimeSpan diff1 = d2.Subtract(d1);
            Console.WriteLine(diff1);

            Console.ReadLine();
        }
    }
}
