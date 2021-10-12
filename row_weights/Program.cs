using System;
using System.Linq;

namespace row_weights
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var test1 = "39 84 74 18 59 72 35 61";
            var test1Arr = test1.Split().Select(int.Parse).ToArray();
            var results = RowWeights(test1Arr);
            System.Console.WriteLine($"A: = {results[0]}, B = {results[1]}");
        }

        public static int[] RowWeights(int[] a)
        {
            int aTotal = 0;
            int bTotal = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0){
                    aTotal += a[i];
                }
                else {
                    bTotal += a[i];
                }
            }
            return new int[2] { aTotal, bTotal }; 
        }
    }
}
