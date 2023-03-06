using ClassLibrary;

namespace ClassWithNumberManipulations
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.SetValue(371); //you can set any integer value
            System.Console.WriteLine("Value: " + number.GetValue()); //Output: 371
            System.Console.WriteLine("IsZero: " + number.IsZero()); //Output: False
            System.Console.WriteLine("IsPositive: " + number.IsPositive()); //Output: True
            System.Console.WriteLine("IsNegative: " + number.IsNegative()); //Output: False
            System.Console.WriteLine("IsOdd: " + number.IsOdd()); //Output: True
            System.Console.WriteLine("IsEven: " + number.IsEven()); //Output: False
            System.Console.WriteLine("IsPrime: " + number.IsPrime()); //Output: False
            System.Console.WriteLine("GetCountOfDigits: " + number.GetCountOfDigits()); //Output: 3
            System.Console.WriteLine("GetSumOfDigits: " + number.GetSumOfDigits()); //Output: 11
            System.Console.WriteLine("GetReverse: " + number.GetReverse()); //Output: 173
            System.Console.WriteLine("ToWords: " + number.ToWords()); //Output: Three Seven One
            System.Console.WriteLine("IsArmstrong: " + number.IsArmstrong()); //Output: True
            System.Console.WriteLine("GetFibonacci: " + number.GetFibonacci()); //Output: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233
            System.Console.WriteLine("isPalindrome: " + number.isPalindrome()); //Output: False
            System.Console.ReadKey();
        }
    }
}
