using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleGroupProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello Friend !!");
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Thanks for entering {0}",name);
            Console.ReadKey();
        }
    }
}
