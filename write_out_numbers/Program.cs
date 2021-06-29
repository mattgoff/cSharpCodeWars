using System;
using System.Collections;
using System.Collections.Generic;

namespace write_out_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // https://www.codewars.com/kata/52724507b149fa120600031d/train/csharp
            Console.WriteLine(Number2Words(1000));

            Console.ReadLine();
        }

        public static Dictionary<int, string> numberNames = new Dictionary<int, string>()
            {
                {0, "zero" }, {1, "one" },
                {2, "two" }, {3, "three" },
                {4, "four" }, {5, "five" },
                {6, "six" }, {7, "seven" },
                {8, "eight" }, {9, "nine" },
                {10, "ten" }, {11, "eleven" },
                {12, "twelve" }, {13, "thirteen" },
                {14, "fourteen" }, {15, "fifteen" },
                {16, "sixteen" }, {17, "seventeen" },
                {18, "eighteen" }, {19, "nineteen" },
                {20, "twenty" }, {30, "thirty" },
                {40, "fourty" }, {50, "fifty" },
                {60, "sixty" }, {70, "seventy" },
                {80, "eighty" }, {90, "ninety" },
                {100, "hundred" }, {1000, "thousand" }
            };

        public static string Number2Words(int n)
        {
            var digitList = new List<int>();
            var tNum = n;

            while(tNum > 0)
            {
                digitList.Add(tNum % 10);
                tNum = tNum / 10;
            }

            var outStringArray = new List<string>();

            if (n == 0)
                outStringArray.Add("zero");

            if (digitList.Count == 1 )
                outStringArray.Add(numberNames[digitList[0]]);

            if (digitList.Count >= 2)
            {
                outStringArray.Add(DoTens(digitList[1], digitList[0]));
            }

            if (digitList.Count >= 3)
            {
                outStringArray.Add("hundred");
                outStringArray.Add(numberNames[digitList[2]]);
            }

            if (digitList.Count == 4)
            {
                outStringArray.Add("thousand");
                outStringArray.Add(numberNames[digitList[3]]);
            }

            if (digitList.Count > 4)
            {
                outStringArray.Add("thousand");
                outStringArray.Add(DoTens(digitList[4], digitList[3]));
            }

            if (digitList.Count == 6)
            {
                outStringArray.Add("hundred");
                outStringArray.Add(numberNames[digitList[5]]);
            }

            outStringArray.Reverse();

            var returnString = String.Join(" ", outStringArray.ToArray()).Trim();
            if (returnString.Contains("zero hundred"))
            {
                return returnString.Replace(" zero hundred", "");
            }
            return returnString;
        }

        public static string DoTens(int n1, int n2)
        {
            if (n1 == 0 && n2 > 0)
                return numberNames[n2];

            if (n1 == 0 && n2 == 0)
                return null;

            if (n1 * n2 == 0)
                return numberNames[n1 * 10];

            if (int.Parse($"{n1}{n2}") <= 19)
                return numberNames[int.Parse($"{n1}{n2}")];

            return $"{numberNames[n1 * 10]}-{numberNames[n2]}";
        }
    }
}
