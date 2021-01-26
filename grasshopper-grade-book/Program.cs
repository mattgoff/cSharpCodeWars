using System;

namespace grasshopper_grade_book
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var results = GetGrade(95, 90 , 93);
      System.Console.WriteLine($"Expected: A Actual: {results}");
    }
    public static char GetGrade(int s1, int s2, int s3)
    {
      var avg = (s1 + s2 + s3) / 3;
        switch(avg)
        {
            case int n when (avg >= 90 && avg <= 100):
                return 'A';
            case int n when (avg >= 80 && avg < 90):
                return 'B';
            case int n when (avg >= 70 && avg < 80):
                return 'C';
            case int n when (avg >= 60 && avg < 70):
                return 'D';
        }
      return 'F';
    }
  }
}
