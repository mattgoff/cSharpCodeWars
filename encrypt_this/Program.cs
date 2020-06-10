using System;
using System.Collections.Generic;

namespace encrypt_this
{

    public class Kata
    {
        public static string EncryptThis(string input)
        {
            var inputSplit = input.Split(" ");
            var returnString = "";

            if (input.Length > 0)
            {
                foreach (var item in inputSplit)
                {
                    var firstLetter = (int)item.ToCharArray()[0];

                    if (item.Length > 2)
                    {
                        var wordSplit = item.ToCharArray();
                        var middle = item.Substring(2, item.Length - 3);
                        returnString += $"{firstLetter}{wordSplit[wordSplit.Length - 1]}{middle}{wordSplit[1]} ";
                    }
                    else
                    {
                        if (item.Length == 2)
                        {
                            returnString += $"{firstLetter}{item[1]} ";
                        }
                        else
                        {
                            returnString += $"{firstLetter} ";
                        }
                    }
                }

            }
            return returnString.TrimEnd();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string test1 = "A wise old owl lived in an oak";
            string test1Answer = "65 119esi 111dl 111lw 108dvei 105n 97n 111ka";
            string test2 = "A";
            string test2Answer = "65";
            System.Console.WriteLine($"Should return {test1Answer}, {Kata.EncryptThis(test1)}");
            System.Console.WriteLine($"Should return {test2Answer}, {Kata.EncryptThis(test2)}");
        }
    }
}
