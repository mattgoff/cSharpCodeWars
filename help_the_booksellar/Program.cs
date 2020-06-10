using System;
using System.Collections.Generic;

namespace help_the_booksellar
{

    public class StockList {

    public static string stockSummary(String[] lstOfArt, String[] lstOf1stLetter) {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        string resultString = "";
        Console.WriteLine($"List of Art {string.Join(",", lstOfArt)}");
        Console.WriteLine($"List of Letters {string.Join(",", lstOf1stLetter)}");

        foreach (var item in lstOfArt)
        {
            var firstLetter = Char.ToString(item[0]);
            var count = Convert.ToInt32(item.Split(" ")[1]);
            if (dict.ContainsKey(firstLetter))
            {
                dict[firstLetter] += count;
            }
            else
            {
                dict.Add(firstLetter, count);
            }
        }

        if (lstOf1stLetter.Length > 0 && lstOfArt.Length > 0)
            foreach (var item in lstOf1stLetter)
            {
                if (dict.ContainsKey(item))
                {
                    resultString = resultString + $"({item} : {dict[item]}) - ";
                }
                else
                {
                    resultString = resultString + $"({item} : 0) - ";
                }
            }

            if (resultString.Length > 3) resultString = resultString.Remove(resultString.Length - 3);

        return resultString;
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] art = new string[] {};
            string[] cd = new string[] {"B", "R", "D", "X"};
            System.Console.WriteLine($"Should Equal (A : 200) - (B : 1140) -> {StockList.stockSummary(art, cd)}");
        }
    }
}
