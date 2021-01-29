using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace error_correction_1_hamming_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var expectedEncode = "000111111000111000000000000111111000000111000111000111111111111000000111";
            var actualEncode = encode("hey");
            System.Console.WriteLine($"Encode -> Actual {actualEncode}  ==  Expected {expectedEncode} = {actualEncode == expectedEncode}");

            var expectedDecode = "hey";
            var actualDecode = decode("100111111000111001000010000111111000000111001111000111110110111000010111");
            System.Console.WriteLine($"Decode -> Actual {actualDecode}  ==  Expected {expectedDecode} = {actualDecode == expectedDecode}");
        }

        public static string encode(string text) {
            string[] asciiValues = new string[text.Length];
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < text.Length; i++){
                string binaryOfasciiNumber = Convert.ToString(text[i] - 0, 2);
                if (binaryOfasciiNumber.Length != 8) { binaryOfasciiNumber = binaryOfasciiNumber.PadLeft(8, '0'); }

                foreach (var numb in binaryOfasciiNumber)
                {
                    sb.Append(String.Concat(Enumerable.Repeat(numb, 3)));
                }
            }
            return sb.ToString();
        }
        public static string decode(string bits) {
            StringBuilder sb = new StringBuilder();
            for (var i = 0; i < bits.Length; i += 3)
            {
                var threebits = bits.Substring(i, 3);
                sb.Append(threebits.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key);
            }
            List<char> letters = new List<char>();
            for (var i = 0; i < sb.ToString().Length; i +=8)
            {
                var eightBits = sb.ToString().Substring(i, 8);
                var asciiChar = Convert.ToChar(Convert.ToInt32(eightBits, 2));
                letters.Add(asciiChar);
            }
            return String.Join("", letters);
        }
    }
}
