using System;

namespace simple_fraction_to_mixed_number_converter
{
  public class Kata
  {
    public static string MixedFraction(string s)
    {
      var stringSplit = s.Split("/");
      var numerator = Int32.Parse(stringSplit[0]);
      var denominator = Int32.Parse(stringSplit[1]);


      if (numerator % denominator == 0)
      {
        return (numerator / denominator).ToString();
      }
      else
      {
        var wholeNumber = numerator / denominator;
        var nonSimplifiedNumerator = Math.Abs(numerator) - Math.Abs(denominator * wholeNumber);

        var gcdValue = GCD(nonSimplifiedNumerator, denominator);
        var simplifiedNumerator = nonSimplifiedNumerator / gcdValue;
        var simplifiedDenominator = denominator / gcdValue;

        return wholeNumber == 0 ? $"{simplifiedNumerator}/{simplifiedDenominator}" : $"{wholeNumber} {simplifiedNumerator}/{simplifiedDenominator}";
      }
    }

    private static int GCD(int a, int b)
    {
      while (a != 0 && b != 0)
      {
        if (a > b)
          a %= b;
        else
          b %= a;
      }

      return a | b;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Kata.MixedFraction("42/9"));
    }
  }
}
