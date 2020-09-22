using System;

namespace the_falling_speed_of_petals
{
  public static class Kata
  {
    public static double SakuraFall(double v)
    {
      if (v <= 0) return 0;
      double fallDistance = 80 * 5;
      return fallDistance / v;
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      var result = Kata.SakuraFall(5);
      System.Console.WriteLine($"Result is {result}");
    }
  }
}
