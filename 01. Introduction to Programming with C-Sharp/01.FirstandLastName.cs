// Write a program that prints your first and last name on the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";
            string lastName = "";

            Console.WriteLine("Good Day!");
            Console.WriteLine();
            Console.Write("First Name: ");
            firstName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Last Name: ");
            lastName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("My name is " + firstName + " " + lastName);
            Console.WriteLine();
        }
    }
}
