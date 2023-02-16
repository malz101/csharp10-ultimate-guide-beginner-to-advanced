using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeetToCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declarations
            double feet;
            double inches;
            double centimeters;

            //print program name
            Console.WriteLine("*Feet to Centimeters*");

            //read feet and inches values
            Console.WriteLine("Enter height");
            Console.Write("Feet: ");
            feet = Convert.ToDouble(Console.ReadLine());
            Console.Write("Inches: ");
            inches = Convert.ToDouble(Console.ReadLine());

            //convert height to centimeters
            centimeters = (feet * 12 + inches) * 2.54;
            Console.WriteLine($"Height in centimeters is {centimeters}");

            Console.ReadKey();
        }
    }
}
