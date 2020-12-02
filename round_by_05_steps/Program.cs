using System;

namespace round_by_05_steps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine(Solution(4.6));
        }

        public static double Solution(double n)
        {
            double returnValue = Math.Floor(n);
            double decVal = n - returnValue;

            if (decVal < .25)
            {
                return returnValue;
            }
            else if ( decVal >= .25 && decVal < .75)
            {
                return returnValue + .5;
            }
            else {
                return returnValue + 1;
            }
        }
    }
}
