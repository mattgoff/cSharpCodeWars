using System;
using System.Collections.Generic;
using System.Linq;

namespace find_the_unique_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var results1 = GetUnique(new [] {3, 2, 2, 2});
            System.Console.WriteLine($"Expected 1 got {results1}");
        }

        public static int GetUnique(IEnumerable<int> numbers)
        {
            //your code
            var count = from n in numbers
                        group n by n into g
                        let numCount = g.Count()
                        select new {Value = g.Key, Count = numCount};

            var unique = from item in count
                        where item.Count == 1
                        select item.Value;

            System.Console.WriteLine($"Unique = {unique.First()}");
            return unique.First();
        }
    }
}
