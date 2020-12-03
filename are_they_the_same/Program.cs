using System;
using System.Linq;

namespace are_they_the_same
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] {121, 144, 19, 161, 19, 144, 19, 11};
            int[] b = new int[] {11*11, 121*121, 144*144, 19*19, 161*161, 19*19, 144*144, 19*19};
            var results = comp(a, b);
             System.Console.WriteLine($"Are they the same: {results}");
        }

        public static bool comp(int[] a, int[] b)
        {
            if (a ==null || b == null) { return false; }
            if (a.Length != b.Length) { return false; }

            int[] copyOfA = a.Select(x => x*x).ToArray();

            Array.Sort(copyOfA);
            Array.Sort(b);

            // return string.Join(",", copyOfA) == string.Join(",", b);
            return copyOfA.SequenceEqual(b);
        }

    }
}
