using System;
using System.Linq;

namespace vowel_count
{

    public static class Kata
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;
            char[] vowelList = new char[5] {'a', 'e', 'i', 'o', 'u'};

            foreach (char letter in str)
            {
              if (vowelList.Contains(letter)){
                  vowelCount ++;
              }
            }

            return vowelCount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine($"5, {Kata.GetVowelCount("abracadabra")}");
        }
    }
}
