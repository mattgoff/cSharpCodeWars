using System;
using System.Linq;

namespace two_sum
{
  public class Kata
  {
    public static int[] TwoSum(int[] numbers, int target)
    {
      int[] indexArray = new int[2];

      for (int i = 0; i < numbers.Length; i++)
      {
          var numberNeeded = target - numbers[i];

          for (int j = i + 1; j < numbers.Length; j++)
          {
              if (numbers[j] == numberNeeded)
              {
                  indexArray[0] = i;
                  indexArray[1] = j;
                  return indexArray;
              }
          }

      }
      return indexArray;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

        Console.WriteLine(Kata.TwoSum(new[] { 1, 2, 3 }, 4).OrderBy(a => a).ToArray());  //Assert.AreEqual(new [] { 0, 2 },
        Console.WriteLine(Kata.TwoSum(new[] { 1234, 5678, 9012 }, 14690).OrderBy(a => a).ToArray()); //Assert.AreEqual(new [] { 1, 2 },
        Console.WriteLine(Kata.TwoSum(new[] { 2, 2, 3 }, 4).OrderBy(a => a).ToArray()); //Assert.AreEqual(new [] { 0, 1 },

    }
  }
}
