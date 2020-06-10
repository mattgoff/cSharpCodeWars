using System;

namespace whats_a_perfect_power_anyways
{
    public class PerfectPower
    {
        public static (int, int)? IsPerfectPower(int y)
        {
            //  PP is when x^n = y and all numbers are whole
            //

            for (int x = 1; x < y; x++)
            {
                var nResult = Math.Round(Math.Log(y) / Math.Log(x), 6);
                if ( nResult % 1 == 0)
                {
                    return (x, Convert.ToInt32(nResult));
                }
            }

            return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine($"{PerfectPower.IsPerfectPower(0)}, 0 is not a perfect number");
            // Console.WriteLine($"{PerfectPower.IsPerfectPower(1)}, 1 is not a perfect number");
            // Console.WriteLine($"{PerfectPower.IsPerfectPower(2)}, 2 is not a perfect number");
            Console.WriteLine($"{PerfectPower.IsPerfectPower(125)}, 3 is not a perfect number");
            // Console.WriteLine($"{PerfectPower.IsPerfectPower(4)}, 4 = 2^2");

        }
    }
}
