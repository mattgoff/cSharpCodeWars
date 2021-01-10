using System;
using System.Linq;

namespace equalize_the_array
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var results = Equalize(new[] { 10, 12, 24, 50, 0, 15, 20 });

      System.Console.WriteLine($"Results : {String.Join(",", results)}");
    }

    public static string[] Equalize(int[] array)
    {
      if (array.Length == 0) return new string[0];

      var returnArr = new String[array.Length];
      returnArr[0] = "+0";

      for (int i = 1; i < array.Length; i++)
      {
        // var returnSign = (array[i] - array[0] > 0 ? "+" : "-");
        var data = (array[i] - array[0]).ToString("+#;-#;+0");
        returnArr[i] = $"{data}";
      }

      return returnArr;
    }

    public static string[] Equalize2(int[] array)
    {
      return array.Select(x => (x - array[0]).ToString("+#;-#;+0")).ToArray();
    }
  }
}
