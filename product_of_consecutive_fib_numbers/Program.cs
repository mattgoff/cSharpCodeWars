using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace product_of_consecutive_fib_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // ulong[] r = new ulong[] { 55, 89, 1 };
            // var results = productFib(4895);
            // Assert.AreEqual(r, results);
            var fiblist = productFib(4895);
            System.Console.WriteLine($"{fiblist[0]} {fiblist[1]} {fiblist[2]}");
        }

        public static ulong[] productFib(ulong prod)
        {
            ulong a = 0, b = 1, c = 0;

            while (a * b < prod)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return (a * b == prod) ? new ulong[] { (ulong)a , (ulong)b, (ulong)1 } : new ulong[] { (ulong)a , (ulong)b, (ulong)0 };
        }
    }
}
