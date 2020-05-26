using System;
using System.Collections.Generic;

namespace friend_or_foe
{
  public static class Kata {
  public static IEnumerable<string> FriendOrFoe (string[] names) {

    List<string> returnList = new List<string>();

    foreach (var name in names)
    {
        if(name.Length == 4) returnList.Add(name);
    }
    return returnList;
  }
  }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] expected = { "Ryan", "Mark" };
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            var results = Kata.FriendOrFoe(names);
            System.Console.WriteLine(results.ToString());
        }
    }
}
