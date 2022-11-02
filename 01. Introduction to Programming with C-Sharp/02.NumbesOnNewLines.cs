// Write a program that prints 1, 101, 1001, each on a new line

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersOnNewLines
{
    class Program
    {
        static void Main(string[] args)
        {            
            int one = 1;
            int oneZeroOne = 101;
            int oneZeroZeroOne = 1001;

            Console.WriteLine(one);
            Console.WriteLine();
            Console.WriteLine(oneZeroOne);
            Console.WriteLine();
            Console.WriteLine(oneZeroZeroOne);
            Console.WriteLine();
            // OR
            Console.WriteLine("1");
            Console.WriteLine("101");
            Console.WriteLine("1001");
        }
    }
}
