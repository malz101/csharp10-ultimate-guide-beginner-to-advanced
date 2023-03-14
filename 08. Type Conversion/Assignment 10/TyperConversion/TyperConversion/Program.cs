//byte a = 10; //Convert this value into "short" type (assign into another short type of variable)
//int b = 10; //Convert this value into "short" type (assign into another short type of variable)
//string c = "10.34"; //Convert this value into "double" type using Parse  //Also, convert the same value into "decimal" type  using TryParse
//decimal d; //Convert this value into "string" type (assign into another string type of variable)
//And then print all the converted values i.e 10, 10, 10.34, 10.34, 11.56.

//You need to consider this order of concepts to prefer for conversion, where the "1" will be the highest priority and the "4" will be the least priority.

//    Implicit Casting

//    Explicit Casting

//    Parse or TryParse (as suggested above)

//    Conversion Methods

namespace TyperConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 10;
            int b = 10;
            string c = "10.34";
            decimal d = 11.56M;

            short aShort = a;
            short bShort = (short)b;
            double cDouble1 = double.Parse(c);
            double.TryParse(c, out double cDouble2);
            string dString = System.Convert.ToString(d);

            System.Console.WriteLine(aShort);
            System.Console.WriteLine(bShort);
            System.Console.WriteLine(cDouble1);
            System.Console.WriteLine(cDouble2);
            System.Console.WriteLine(dString);

            System.Console.ReadKey();
        }
    }
}
