using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declarations
            double radius;
            double pi = 3.14159;
            double area;

            Console.WriteLine("*Area of Circle Calculator*");
            Console.WriteLine();
            Console.Write("Enter radius of circle: ");
            radius = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine();

            area = pi * radius * radius;

            Console.WriteLine($"Area of circle is {area}");
            
            Console.ReadKey();
        }
    }
}
