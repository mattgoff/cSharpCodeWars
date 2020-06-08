using System;
using System.Linq;

namespace equal_sides_of_an_array
{
    public class Kata
    {
        public static int FindEvenIndex(int[] arr)
        {
            for (int i = 0; i < arr.Length; i ++)
            {
                int[] firstPortion = new int[i + 1];
                int[] lastPortion = new int[arr.Length - i];

                Array.Copy(arr, 0, firstPortion, 0, (i + 1) );
                Array.Copy(arr, i, lastPortion, 0, (arr.Length - (i)));

                if ( firstPortion.Sum() == lastPortion.Sum()) return i;

            }

            return -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] s1 = new int[] {1,2,3,4,3,2,1};
            int[] s2 = new int[] {1,100,50,-51,1,1};
            int[] s3 = new int[] {1,2,3,4,5,6};
            int[] s4 = new int[] {20,10,30,10,10,15,35};

            Console.WriteLine("Hello World!");
            Console.WriteLine($"Should return 3, {Kata.FindEvenIndex(s1)}");
            Console.WriteLine($"Should return 1, {Kata.FindEvenIndex(s2)}");
            Console.WriteLine($"Should return -1, {Kata.FindEvenIndex(s3)}");
            Console.WriteLine($"Should return 3, {Kata.FindEvenIndex(s4)}");
        }
    }
}
