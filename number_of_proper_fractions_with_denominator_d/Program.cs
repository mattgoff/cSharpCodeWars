using System;
using System.Collections.Generic;
using System.Linq;

namespace number_of_proper_fractions_with_denominator_d
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      System.Console.WriteLine($"Expected -> 0 Got -> {ProperFractions(1)}");
      System.Console.WriteLine($"Expected -> 1 Got -> {ProperFractions(2)}");
      System.Console.WriteLine($"Expected -> 4 Got -> {ProperFractions(5)}");
      System.Console.WriteLine($"Expected -> 8 Got -> {ProperFractions(15)}");
      System.Console.WriteLine($"Expected -> 20 Got -> {ProperFractions(25)}");

    }

    public static long ProperFractions(long n)
    {
        if (n==1)
        {
            return 0;
        }

        long result = n;
        for (long i = 2; i * i <= n; i++)
        {
            if(n % i == 0)
            {
                while(n % i == 0)
                {
                    n /= i;
                }
                result -= result / i;
            }
        }
        if(n > 1)
        {
            result -= result / n;
        }

        return result;
    }
  }
}
