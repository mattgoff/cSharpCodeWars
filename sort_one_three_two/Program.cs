using System;
using System.Collections.Generic;
using System.Linq;

namespace sort_one_three_two
{
    class Program
    {
        public static Dictionary<int, string> ConverterDict = new Dictionary<int, string>(){ 
            {0, ""},{1, "one"},{2, "two"},{3, "three"},{4, "four"},{5, "five"},
            {6, "six"},{7, "seven"},{8, "eight"},{9, "nine"},{10, "ten"}, {11, "eleven"},
            {12, "tweleve"},{13, "thirteen"},{14, "fourteen"},{15, "fifteen"},{16, "sixteen"},
            {17, "seventeen"},{18, "eighteen"},{19, "nineteen"},{20, "twenty"},{30, "thirty"},
            {40, "forty"},{50, "fifty"},{60, "sixty"},{70, "seventy"},{80, "eighty"},{90, "ninety"},
            {100, "hundred"}          
            };
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] testGroup1 = new int[2]{847, 0};
            var response = new int[testGroup1.Length];
            response = Sort(testGroup1);
            foreach (var item in response)
            {
                System.Console.WriteLine(item);
            }
        }

        public static string StringValue(int num){
            int intLenth = num.ToString().Length;
            List<int> nums_pos = new List<int>();
   
            for (int i = 0; i < intLenth; i++)
            {
                int val = num % 10;
                nums_pos.Add(val);
                num /= 10;
            }
            nums_pos.Reverse();

            var retString = "";
            if (nums_pos.Count() == 3){
                retString += ConverterDict[nums_pos[0]];
                retString += " hundred ";
                nums_pos.RemoveAt(0);
            }

            if (nums_pos.Count() == 2){
                if (nums_pos[0] == 1)
                {
                    var tval = nums_pos[0] * 10 + nums_pos[1];
                    retString += ConverterDict[tval];
                    nums_pos.RemoveRange(0, 2);
                }
                else{
                    if (nums_pos[0] != 0){
                        var tval = nums_pos[0] * 10;
                        retString += ConverterDict[tval] + " ";
                    }
                    nums_pos.RemoveAt(0);
                }
            }

            if (nums_pos.Count() == 1){
                if( nums_pos[0] == 0 && intLenth == 1)
                {
                    retString = "zero";
                }
                else{
                    retString += ConverterDict[nums_pos[0]];
                    nums_pos.RemoveAt(0);
                }
            }

            return retString;
        }
        public static int[] Sort(int[] array)
        {
            var results = new List<List<string>>();

            foreach (var item in array)
            {
                var tlist = new List<string>();
                tlist.Add(item.ToString());
                tlist.Add(StringValue(item));
                results.Add(tlist);
            }

            var sorted = results.OrderBy(x => x[1]).ToList();
            var returnArray = new List<int>();

            foreach (var item in sorted)
            {
                returnArray.Add(int.Parse(item[0]));    
            }
            return returnArray.ToArray();
        }
        
    }
}
