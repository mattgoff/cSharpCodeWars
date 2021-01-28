using System;

namespace growth_of_a_popluation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var result = NbYear(1500, 5, 100, 5000);
            System.Console.WriteLine($"Expected: 3 Actual: {result}");
        }
        public static int NbYear(int p0, double percent, int aug, int p) {
            int popCounter = p0;
            int yearCounter = 0;
            double percentage = percent / 100;

            while (popCounter <= p )
            {
                popCounter = popCounter + Convert.ToInt32(Math.Floor(popCounter * percentage)) + aug;
                yearCounter ++;
            }
            return yearCounter;
        }
    }
}
