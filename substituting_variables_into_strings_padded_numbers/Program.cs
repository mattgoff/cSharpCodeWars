using System;

namespace substituting_variables_into_strings_padded_numbers
{
  public class PaddedNumbers
  {
    public static string Solution(int value)
    {
      var valueLength = value.ToString().Length;
      string padding = new string('0', 5 - valueLength);
      return $"Value is {padding}{value}";
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(PaddedNumbers.Solution(5));
    }
  }
}
