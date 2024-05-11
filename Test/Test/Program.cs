using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            int result = calc.Add(5, 3);
            Console.WriteLine("5 + 3 = " + result);

            int result2 = calc.Subtract(10, 4);
            Console.WriteLine("10 - 4 = " + result2);

            Console.ReadKey();
        }
    }
}
