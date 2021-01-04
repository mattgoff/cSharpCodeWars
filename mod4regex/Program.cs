using System;
using System.Text.RegularExpressions;

namespace mod4regex
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    //   var result = Mod.MOD4("[+05620]");
    }
  }

  public class Mod
  {
    public static Regex MOD4 = new Regex(".*\\[[+-]?([048]|[0-9]*([02468][048]|[13579][26]))\\]");
  }
}
