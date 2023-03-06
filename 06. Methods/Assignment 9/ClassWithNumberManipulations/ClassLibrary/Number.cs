namespace ClassLibrary
{
    public class Number
    {
        private int value;



        /// <summary>
        /// Receives a numeric value as argument and assigns the same into the 'value' field.
        /// </summary>
        /// <param name="value">the value to assign into the 'value' field/>
        public void SetValue(int value)
        {
            this.value = value;
        }


        /// <summary>
        /// Returns the numeric value of the current instance.
        /// </summary>
        public double GetValue()
        {
            return (double)this.value;
        }


        /// <summary>
        /// Returns a boolean value that indicates whether the current numeric value is equal to zero or not.
        /// </summary>
        public bool IsZero()
        {
            return this.value == 0;
        }


        /// <summary>
        /// Returns a boolean value that indicates whether the current numeric value is a positive number or not.
        /// </summary>
        public bool IsPositive()
        {
            return this.value > 0;
        }


        /// <summary>
        /// Returns a boolean value that indicates whether the current numeric value is a negative number or not.
        /// </summary>
        public bool IsNegative()
        {
            return this.value < 0;
        }


        /// <summary>
        /// Returns a boolean value that indicates whether the current numeric value is a odd number or not.
        /// </summary>
        public bool IsOdd()
        {
            return (this.value % 2) == 1;
        }


        /// <summary>
        /// Returns a boolean value that indicates whether the current numeric value is a even number or not.
        /// </summary>
        public bool IsEven()
        {
            return (this.value % 2) == 0;
        }


        /// <summary>
        /// Returns a boolean value that indicates whether the current numeric value is a prime number or not.
        /// </summary>
        public bool IsPrime()
        {
            if (this.value <= 2)
                return (this.value == 2) ? true : false;

            int i = 2;
            while (true)
            {
                if ((this.value % i) == 0)
                    return false;

                if (i * i > this.value)
                    return true;
                
                i++;
            }
        }


        /// <summary>
        /// Returns power value of given baseNumber. "baseNumber power exponent". <br/>
        /// Eg: baseNumber is "2". exponent is "3". So the method should return the value of "2 power 3" (2 * 2 * 2) = 8. <br/> <br/>
        /// If the "recursive = true", this method should find the power value using 'recursion' technique; otherwise, using normal 'for' loop <br/>
        /// </summary>
        /// <param name="baseNumber">base number</param>
        /// <param name="exponent">exponent</param>
        /// <param name="recursive">specifies whether power value should be found using recursion.</param>
        public static int Power(int baseNumber, int exponent, bool recursive = false)
        {
            if (recursive)
            {
                if (exponent == 0)
                    return 1;
                return baseNumber * Power(baseNumber, --exponent, recursive);
            }
            else
            {
                int result = 1;
                for (int i = exponent; i > 0; i--)
                    result *= baseNumber;
                return result;
            }
        }


        /// <summary>
        /// Returns the count of digits in a number.<br/>
        /// Eg: If the number is "98765", it has "5" digits. So the method returns '5'.
        /// </summary>
        public int GetCountOfDigits()
        {
            int numberOfDigits = 0;
            int temp = this.value; //store value of value field to do manipulations

            //get absolute value of number. Necessary in cases where number is negative
            //temp = this.IsNegative()? this.value * -1 : this.value;

            //calculate lenght of number
            do
            {
                numberOfDigits++;
                temp /= 10;
            } while (temp != 0);

            return numberOfDigits;
        }


        /// <summary>
        /// Returns sum of all digits in a number. <br/>
        /// Eg: If the number is "1234", it should calculate "1+2+3+4". So it's "10".
        /// </summary>
        public int GetSumOfDigits()
        {
            int temp = this.value; //store value of value field to do manipulations
            int sumOfDigits = 0;

            while (temp != 0)
            {
                sumOfDigits += temp % 10;
                temp /= 10;
            }

            return sumOfDigits;

        }


        /// <summary>
        /// Returns reverse of the number.<br/>
        /// Eg: If the number is "1234", its reverse is "4321".
        /// </summary>
        public int GetReverse()
        {
            int temp = this.value; //store value of value field to do manipulations
            int numberOfDigits = this.GetCountOfDigits();
            int reverseValue = 0;

            for(int exponent = numberOfDigits-1 ; exponent >= 0; exponent--)
            {
                reverseValue += (temp % 10) * Number.Power(10, exponent);
                temp /= 10;
            }

            return reverseValue;
        }


        /// <summary>
        /// Returns all digits of the number, as words.<br/>
        /// Eg: If the number is "9840", then the same number in words is "Nine Eight Four Zero".
        /// </summary>
        public string ToWords()
        {
            int temp = this.IsNegative() ? this.value * -1 : this.value; //store value of value field to do manipulations
            string numberInWords = "";

            do
            {
                numberInWords = Number.GetWord(temp % 10) + " " + numberInWords;

                temp /= 10;
            } while (temp != 0);

            return numberInWords.Trim();
        }//End ToWords


        /// <summary>
        /// Returns the given digit in words.<br/>
        /// Eg: if the argument value is "1", it returns "One".
        /// </summary>
        public static string GetWord(int digit)
        {
            string result;

            switch (digit)
            {
                //positive numbers
                case 0: result = "Zero"; break;
                case 1: result = "One"; break;
                case 2: result = "Two"; break;
                case 3: result = "Three"; break;
                case 4: result = "Four"; break;
                case 5: result = "Five"; break;
                case 6: result = "Six"; break;
                case 7: result = "Seven"; break;
                case 8: result = "Eight"; break;
                case 9: result = "Nine"; break;
                default: result = "undefined";  break;
            }

            return result;
        }


        /// <summary>
        /// Returns a boolean value that indicates whether the current numeric value is an Armstrong number or not.<br/>
        /// Armstrong number is a number where the sum of its digits raised to the 'n' power is equal to the number itself, where the 'n' is the 'number of digits of the number'.<br/>
        /// Eg: number is '371'. number of digits is "3" because the number has 3 digits.<br/>
        /// 371 == (3*3*3) + (7*7*7) + (1*1*1)<br/>
        /// 371 == (27) + (343) + (1)<br/>
        /// 371 == 371<br/>
        /// </summary>
        public bool IsArmstrong()
        {
 
            if (this.IsNegative())
                return false;
            else
            {
                int numberOfDigits = this.GetCountOfDigits();
                int sumOfDigitsRaisedToN = 0;
                int temp = this.value; //store value of value field to do manipulations

                for (int i=0; i < numberOfDigits; i++)
                {
                    sumOfDigitsRaisedToN += Number.Power(temp % 10, numberOfDigits);
                    temp /= 10;
                }

                return sumOfDigitsRaisedToN == this.value;
            }
        }


        /// <summary>
        /// prints Fibonacci series from "0" to "current numeric value" i.e "value" field.<br/>
        /// Eg: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, ...
        /// <para>
        /// By default, we will consider minimum of two numbers i.e "0" and "1" in the series. The next number is found by adding up the two numbers before it:<br/>
        /// - the 1 is found by adding the two numbers before it (0+1),<br/>
        /// - the 2 is found by adding the two numbers before it(1+1),<br/>
        /// - the 3 is found by adding the two numbers before it(1+2),<br/>
        /// - the 5 is (2+3),<br/>
        /// - the 8 is (3+5),<br/>
        /// and so on!
        /// </para>
        /// </summary>
        public string GetFibonacci()
        {
            if (this.IsNegative())
            {
                return "Invalid, number less than zero.";
            }
            else
            {
                int temp;
                int fibNMinus1 = 0;
                int fibN = 1;
                string fibString = "0";

                while(fibN <= this.value)
                {
                    fibString += ", " + fibN;
                    temp = fibN;
                    fibN = fibNMinus1 + fibN;
                    fibNMinus1 = temp;
                }

                return fibString.Trim();
            }

        }


        /// <summary>
        /// Returns true, if the number ('value' field) is a palindrome number<br/>
        /// </summary>
        public bool isPalindrome()
        {
            return this.value == this.GetReverse();
        }

    }//End Number class
}//End ClassLibrary namespace
