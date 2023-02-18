//Write a C# program to find out largest number among three numbers, using "if".

//Eg:

//num1 = 60

//num2 = 45

//num3 = 123

//Output: 123

using System;

namespace LargestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            int largest;

            Console.WriteLine("*Largest of Three Numbers*");

            Console.Write("Enter num 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter num 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter num 3: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            largest = num1;

            if(largest < num2)
                largest = num2;
            if (largest < num3)
                largest = num3;



            Console.WriteLine($"Largest: {largest}");

            Console.ReadKey();
        }
    }
}
