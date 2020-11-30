using System;

namespace reversed_sequence
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Kata.ReverseSeq(5);

    //    Assert.That(Kata.ReverseSeq(5), Is.EqualTo(new int[] {5,4,3,2,1}));
    }
  }

  public static class Kata
  {
    public static int[] ReverseSeq(int n)
    {
      var returnArray = new int[n];

      for(var i =  n; i > 0; i--)
      {
          returnArray[ n - i ] = i;
      }

      return returnArray;
    }
  }
}
