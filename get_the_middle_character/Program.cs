using System;

namespace get_the_middle_character
{
    public class Kata
    {
    public static string GetMiddle(string s)
    {
        var length = s.Length % 2 == 0 ? 2 : 1;
        return s.Substring((s.Length - 1) / 2, length );
    }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine($"{Kata.GetMiddle("test")} should equal 'es'");
            System.Console.WriteLine($"{Kata.GetMiddle("testing")} should equal 't'");
            System.Console.WriteLine($"{Kata.GetMiddle("middle")} should equal 'dd'");
            System.Console.WriteLine($"{Kata.GetMiddle("A")} should equal 'A'");
        }
    }
}
