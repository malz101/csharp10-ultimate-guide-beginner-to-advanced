//Write a C# program to print the following output:

//    1 2 3 4 7 8 9 10
//    1 2 3 4 7 8 9 10
//    1 2 3 4 7 8 9 10
//    10 9 8 7 6 5 4 3 2 1
//    10 9 8 7 6 5 4 3 2 1
//    10 9 8 7 6 5 4 3
//    10 9 8 7 6 5 4 3 2 1
//    1 2 3 4 5 6 7 9 10


//Each number should be printed by using the loop variable.

//Don't print full line at-a-time as string.

//For example, don't write statements as:

//System.Console.WriteLine("1 2 3 4 7 8 9 10");

//Use for loop, break and continue statements to bring the output.

using System;

namespace PatternPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            //for lines 1-3
            for(int i=0; i <3; i++)
            {
                for(int j=1; j<=10; j++)
                {
                    if (j == 5 || j == 6)
                        continue;
                    Console.Write(j + " ");
                }
                //moves cursor to new line
                Console.WriteLine();
            }

 

            //for lines 4-7
            for(int i=0; i<4; i++)
            {
                for(int j=10; j>=1; j--)
                {
                    if (i == 2 && j == 2)
                        break;
                    Console.Write(j + " ");
                }
                //moves cursor to new line
                Console.WriteLine();
            }

            //for line 8
            for(int i=1; i<=10; i++)
            {
                if (i == 8)
                    continue;
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}
