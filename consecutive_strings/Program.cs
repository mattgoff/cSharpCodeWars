using System;
using System.Collections.Generic;
using System.Linq;

namespace consecutive_strings
{

    public class LongestConsecutives
{

    public static String LongestConsec(string[] strarr, int k)
    {
        if (strarr.Length == 0 || strarr.Length < k || k <= 0)
        {
            return "";
        }

        List<string> allCombonations = new List<string>();

        for (int i = 0; i < strarr.Length - (k - 1); i++)
        {
            var tempString = "";
            for (int j = 0; j < k; j ++)
            {
                tempString += strarr[i + j];
            }
            allCombonations.Add(tempString);
        }
        return allCombonations.OrderByDescending( s => s.Length ).First();
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(LongestConsecutives.LongestConsec(new String[] {"zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"}, 2) + " should equal abigailtheta");
            Console.WriteLine(LongestConsecutives.LongestConsec(new String[] {"ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh"}, 1) + " should equal oocccffuucccjjjkkkjyyyeehh");
            Console.WriteLine(LongestConsecutives.LongestConsec(new String[] {}, 3)  + " should equal ");
            Console.WriteLine(LongestConsecutives.LongestConsec(new String[] {"itvayloxrp","wkppqsztdkmvcuwvereiupccauycnjutlv","vweqilsfytihvrzlaodfixoyxvyuyvgpck"}, 2) + " should equal wkppqsztdkmvcuwvereiupccauycnjutlvvweqilsfytihvrzlaodfixoyxvyuyvgpck");
            Console.WriteLine(LongestConsecutives.LongestConsec(new String[] {"wlwsasphmxx","owiaxujylentrklctozmymu","wpgozvxxiu"}, 2) + " should equal wlwsasphmxxowiaxujylentrklctozmymu");
            Console.WriteLine(LongestConsecutives.LongestConsec(new String[] {"zone", "abigail", "theta", "form", "libe", "zas"}, -2) + " should equal ");
            Console.WriteLine(LongestConsecutives.LongestConsec(new String[] {"it","wkppv","ixoyx", "3452", "zzzzzzzzzzzz"}, 3) + " should equal ixoyx3452zzzzzzzzzzzz");
            Console.WriteLine(LongestConsecutives.LongestConsec(new String[] {"it","wkppv","ixoyx", "3452", "zzzzzzzzzzzz"}, 15) + " should equal ");
            Console.WriteLine(LongestConsecutives.LongestConsec(new String[] {"it","wkppv","ixoyx", "3452", "zzzzzzzzzzzz"}, 0) + " should equal ");
        }
    }
}
