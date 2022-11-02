using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionThree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints the current Date and Time.
            Console.WriteLine("Current Date and Time is : ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now); 
            // OR
            Console.WriteLine("Current Date and Time is : " + System.DateTime.Now);
        }
    }
}
