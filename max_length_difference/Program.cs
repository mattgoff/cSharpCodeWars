using System;
using System.Linq;

namespace max_length_difference
{

    public class MaxDiffLength
    {

        public static int Mxdiflg(string[] a1, string[] a2)
        {
            if (a1.Length == 0 || a2.Length == 0)
            {
                return -1;
            }

            string[] a1ShortestAndLongest = new string[2];
            string[] a2ShortestAndLongest = new string[2];

            a1ShortestAndLongest[0] = (a1.OrderByDescending(s => s.Length).First());
            a1ShortestAndLongest[1] = (a1.OrderByDescending(s => s.Length).Last());

            a2ShortestAndLongest[0] = (a2.OrderByDescending(s => s.Length).First());
            a2ShortestAndLongest[1] = (a2.OrderByDescending(s => s.Length).Last());

            int varDiffa1Minus2 = a1ShortestAndLongest[0].Length - a2ShortestAndLongest[1].Length;
            int varDiffa2Minus1 = a2ShortestAndLongest[0].Length - a1ShortestAndLongest[1].Length;

            return Math.Max(varDiffa1Minus2, varDiffa2Minus1);

            // a better way
            // var first = Math.Abs(a1.Max(x => x.Length) - a2.Min(x => x.Length));
            // var second = Math.Abs(a2.Max(x => x.Length) - a1.Min(x => x.Length));
            // return Math.Max(first, second);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        string[] s1 = new string[]{"hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz"};
        string[] s2 = new string[]{"cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww"};
        System.Console.WriteLine($"Should return 13, {MaxDiffLength.Mxdiflg(s1, s2)}");
        }
    }
}
