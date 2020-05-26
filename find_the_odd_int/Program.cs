using System;

namespace find_the_odd_int
{

    class Kata
    {
    public static int find_it(int[] seq)
      {
          for (int i = 0; i < seq.Length; i++)
          {
              var currentInt = seq[i];
              var currentIntCount = 0;

            foreach (var item in seq)
            {
                if (item == currentInt) currentIntCount ++;
            }

            if ( currentIntCount % 2 != 0) return currentInt;
          }
      return -1;
      }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var testResults = Kata.find_it ( new[] { 20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5 });
            System.Console.WriteLine($"Results: {testResults}");
        }
    }
}
