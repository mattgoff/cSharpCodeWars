using System;
using System.Collections.Generic;

namespace count_chars_in_your_string
{
    public class Kata
        {
            public static Dictionary<char, int> Count(string str)
                {
                    Dictionary<char, int> returnDict = new Dictionary<char, int>();

                    char[] charArray = str.ToCharArray();

                    foreach (var letter in charArray)
                    {
                        if (returnDict.ContainsKey(letter))
                        {
                            returnDict[letter] += 1;
                        }
                        else
                        {
                            returnDict.Add(letter, 1);
                        }
                    }
                    return returnDict;
                }
        }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var aaa = Kata.Count("aaa");
            foreach (KeyValuePair<char, int> entry in aaa)
            {
                System.Console.WriteLine($"Key = {entry.Key}  Value = {entry.Value}");
            }
        }
    }
}