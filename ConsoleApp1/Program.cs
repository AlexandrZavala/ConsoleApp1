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
            double a, b;

            Console.WriteLine("Enter a - ");
            a= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter b - ");
            b = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Equal - " + (a*b));
        }
    }
}
