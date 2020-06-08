using System;

namespace sum_of_a_squence
{
    public static class Kata
    {
        public static int SequenceSum(int start, int end, int step)
        {
            int total = 0;

            for (int i = start; i <= end; i += step )
            {
                total += i;
            }
            return total;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Should Equal - 12, {Kata.SequenceSum(2, 6, 2)}");
            Console.WriteLine($"Should Equal - 15, {Kata.SequenceSum(1, 5, 1)}");
            Console.WriteLine($"Should Equal - 5, {Kata.SequenceSum(1, 5, 3)}");
            Console.WriteLine($"Should Equal - 45, {Kata.SequenceSum(0, 15, 3)}");
            Console.WriteLine($"Should Equal - 0, {Kata.SequenceSum(16, 15, 3)}");
            Console.WriteLine($"Should Equal - 26, {Kata.SequenceSum(2, 24, 22)}");
            Console.WriteLine($"Should Equal - 2, {Kata.SequenceSum(2, 2, 2)}");
            Console.WriteLine($"Should Equal - 2, {Kata.SequenceSum(2, 2, 1)}");
            Console.WriteLine($"Should Equal - 35, {Kata.SequenceSum(1, 15, 3)}");
            Console.WriteLine($"Should Equal - 0, {Kata.SequenceSum(15, 1, 3)}");
        }
    }
}
