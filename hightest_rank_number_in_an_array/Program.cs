using System;
using System.Linq;

namespace hightest_rank_number_in_an_array
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var arr = new int[] { 3, 5, 3, 6, 3, 3, 7, 4, 6, 3, 4, 5, 5 };
      System.Console.WriteLine($"{HighestRank(arr)} should be 12");
    }

    public static int HighestRank(int[] arr)
    {
        var lq = from n in arr
                    group n by n into grp
                    orderby grp.Count() descending, grp.Key descending
                    select new {key = grp.Key, cnt = grp.Count()};

        var result = lq.FirstOrDefault();

      return result.key;
    }
  }
}
