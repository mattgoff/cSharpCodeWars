using System;

namespace character_with_longest_consecutive_repetition
{

  public static class Kata
  {
    public static Tuple<char?, int> LongestRepetition(string input)
    {
        if (input == String.Empty)
        {
            return new Tuple<char?, int>(null, 0);
        }

        int currentCounter = 1;
        int longestCounter = 0;
        char longestChar = input[0];
        char previousChar = char.MinValue;

        foreach (var character in input)
        {
            if (character != previousChar)
            {
                currentCounter = 1 ;
            }
            else
            {
                currentCounter ++;
            }

            if (currentCounter > longestCounter)
            {
                longestChar = character;
                longestCounter = currentCounter;
            }
            previousChar = character;
        }
        return new Tuple<char?, int>( longestChar, longestCounter);
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var myResult = Kata.LongestRepetition("aaabbbcccc");
      System.Console.WriteLine($"Result => {myResult}");
    }
  }
}
