using System;

namespace multiplication_table
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      int[,] expected = new int[,]{{1,2,3},{2,4,6},{3,6,9}};
      var actual = Solution.MultiplicationTable(3);

    }
  }

  class Solution
  {
    public static int[,] MultiplicationTable(int size)
    {
      int[,] returnArray = new int[size, size];
      for (int x = 0; x < size; x++)
      {
          for (int y = 0; y < size; y++)
          {
            returnArray[x, y] = (x + 1) * (y + 1);
            // System.Console.WriteLine($"{x},{y} = {(x + 1) * (y + 1)}");
          }
      }
      return returnArray;
    }
  }
}
