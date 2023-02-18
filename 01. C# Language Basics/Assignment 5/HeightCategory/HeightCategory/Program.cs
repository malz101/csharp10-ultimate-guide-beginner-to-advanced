//Height categories:

//Height is less than 150 cm = "Dwarf"

//Height is between 150 cm and 165 cm = "Average height"

//Height is between 165 cm and 195 cm = "Tall"

//Height is above 195 cm = "Abnormal height"


//Note: 1 inch = 2.54 centimeter

//You need to convert the input value (inches) into centimeters.


//Eg:

//Input: 75

//Output: Tall

using System;

namespace HeightCategory
{
    class Program
    {
        static void Main(string[] args)
        {
            double height;
            string category;

            Console.WriteLine("*Height Category*");

            Console.Write("Enter height in inches: ");
            height = Convert.ToDouble(Console.ReadLine()) * 2.54;

            if (height < 150)
                category = "Dwarf";
            else if (height >= 150 && height < 165)
                category = "Average height";
            else if (height >= 165 && height < 195)
                category = "Tall";
            else
                category = "Abnormal height";

            Console.WriteLine($"Category: {category}");

            Console.ReadKey();

        }
    }
}
