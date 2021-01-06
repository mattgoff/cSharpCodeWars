using System;

namespace bouncing_balls
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      System.Console.WriteLine($"Expected: 1 Got: {bouncingBall(2.0, 0.5, 1)}");
    //   System.Console.WriteLine($"15 should equal {bouncingBall(30.0, 0.66, 1.5)}");
    }

    public static int bouncingBall(double h, double bounce, double window)
    {
      System.Console.WriteLine($"Orginals  h: {h}  bounce: {bounce}  window: {window}");
      if (h <= 0 || bounce <= 0 || bounce >= 1 || window >= h)
      {
        return -1;
      }

      int bounceCount = 0;
      double bounceHeight = h;

      while (bounceHeight > window)
      {
        bounceCount++;
        bounceHeight = bounce * bounceHeight;
        System.Console.WriteLine($"BounceCount: {bounceCount} BounceHeight: {bounceHeight}");

        if (bounceHeight > window)
        {
          bounceCount++;
        }

      }

      return bounceCount;
    }
  }
}
