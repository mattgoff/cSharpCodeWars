using System;
using System.Collections;

namespace find_the_middle_unit
{
    public class Kata
    {
        public static int Gimme(double[] inputArray)
        {
            double[] tempArray = new double[inputArray.Length];
            Array.Copy(inputArray, tempArray, inputArray.Length);
            Array.Sort(tempArray);
            return Array.IndexOf(inputArray, tempArray[1]);

            // using system.linq this can be one lined
            // Array.IndexOf(inputArray, inputArray.OrderBy(x => x).ToArray()[1]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var k1 = Kata.Gimme(new double[] {2, 3, 1});
            var k2 = Kata.Gimme(new double[] {5, 10, 14});
            System.Console.WriteLine($"0, {k1}");
            System.Console.WriteLine($"1, {k2}");
        }
    }
}
