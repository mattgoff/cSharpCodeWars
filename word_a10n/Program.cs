using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace word_a10n
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = Abbreviate("my. dog, isn't feeling very well.");
            // var results = Abbreviate("elephant-rides");
            Console.WriteLine(results);
        }

        public static string Abbreviate(string input)
        {
            var splitString = input.Split(" ");

            List<string> returnString = new List<string>();

            foreach (var item in splitString)
            {
                returnString.Add(CheckWord(item));
            }

            return String.Join(" ", returnString);
        }

        public static string CheckWord(string wordToCheck)
        {
            if (wordToCheck.Length < 4) return wordToCheck;

            bool hasAllAlpha = wordToCheck.All(Char.IsLetter);

            if (hasAllAlpha)
            {
                return ConvertWord(wordToCheck);
            }

            char[] charArray = wordToCheck.ToCharArray();
            List<string> arrayWordList = new List<string>();
            string tempWord = "";

            foreach (var letter in charArray)
            {
                if (Char.IsLetter(letter))
                {
                    tempWord += letter;
                }
                else{
                    arrayWordList.Add(tempWord);
                    arrayWordList.Add(Char.ToString(letter));
                    tempWord = "";
                }
            }

            if (tempWord.Length > 0) arrayWordList.Add(tempWord);

            List<string> returnList = new List<string>();

            foreach (var item in arrayWordList)
            {
                var tempword = ConvertWord(item);
                returnList.Add(tempword);
            }

            return String.Join("", returnList);
        }

        public static string ConvertWord(string wordToConvert)
        {
            if (wordToConvert.Length < 4) return wordToConvert;

            return $"{wordToConvert.First()}{wordToConvert.Length - 2}{wordToConvert.Last()}";
            // return $"{wordToConvert[0]}{wordToConvert.Length - 2}{wordToConvert[wordToConvert.Length - 1]}";
        }
    }
}
