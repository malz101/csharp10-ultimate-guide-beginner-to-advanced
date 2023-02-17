//Instructions

//If the number's last three digits are greater than or equal to 500; it should "round up" the number.

//If the number's last three digits are less than 500; it should "round down" the number.

//If the number is less than 500; it should round up to 1000.


//Eg:

//Input: 499  Output: 1000

//Input: 500  Output: 1000

//Input: 999  Output: 1000

//Input: 1000 Output: 1000

//Input: 1499 Output: 1000

//Input: 1500 Output: 2000

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearestThousand
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int num;
            int ans;
            string programName = "*Nearest Thousand*";
            string labelInput = "Input: ";
            string labelOutput = "Output: ";

            Console.WriteLine(programName);
            
            
            while(true){
                Console.WriteLine();
                Console.Write(labelInput);

                //read input
                input = Console.ReadLine();
                num = Convert.ToInt32(input);

                if (num < 1000)
                    ans = 1000;
                else
                {
                    int remainder = num % 1000;
                    ans = remainder < 500 ? num - remainder : num - remainder + 1000;
                }

                Console.SetCursorPosition(labelInput.Length + input.Length, Console.CursorTop - 1);
                Console.WriteLine($"\t{labelOutput}{ans}");

                Console.Write("Enter CRTL+C to exit. Press any other key to continue...");
                Console.ReadKey();
                Console.WriteLine();
            }

        }
    }
}
