using System;

namespace holiday_vi___shark_pontoon
{

  public class Kata
  {
    public static string Shark(
      int pontoonDistance,
      int sharkDistance,
      int yourSpeed,
      int sharkSpeed,
      bool dolphin)
    {

        var myTime = pontoonDistance / yourSpeed;
        var sharkTime = dolphin ? sharkDistance / (sharkSpeed / 2) : sharkDistance / sharkSpeed;

        return (myTime < sharkTime) ? "Alive!" : "Shark Bait!";
    }
  }
    class Program
    {
      static void Main(string[] args)
      {
        Console.WriteLine("Hello World!");
        System.Console.WriteLine($"Alive - {Kata.Shark(12, 50, 4, 8, true)}");
        System.Console.WriteLine($"Alive - {Kata.Shark(12, 50, 4, 8, false)}");
        System.Console.WriteLine($"Alive - {Kata.Shark(7, 55, 4, 16, true)}");
        System.Console.WriteLine($"Shark Bait - {Kata.Shark(24, 0, 4, 8, true)}");
        System.Console.WriteLine($"Shark Bait - {Kata.Shark(40, 35, 3, 20, true)}");
        System.Console.WriteLine($"Alive - {Kata.Shark(7, 8, 3, 4, true)}");
        System.Console.WriteLine($"Shark Bait - {Kata.Shark(7, 8, 3, 4, false)}");
      }
    }
  }
