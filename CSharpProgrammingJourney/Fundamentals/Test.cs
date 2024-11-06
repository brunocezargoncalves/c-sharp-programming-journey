using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingJourney.Fundamentals
{
    class Test
    {
        public static void Execute()
        {
            List<int> arr = new List<int> { 256741038, 623958417, 467905213, 714532089, 938071625 };

            var min = arr.Min();
            var max = arr.Max();

            long sumMin = 0;
            long sumMax = 0;

            arr.Remove(max);
            sumMin = arr.Sum();

            arr.Add(max);

            arr.Remove(min);
            sumMax = arr.Sum();

            Console.WriteLine("{0} {1}", sumMin, sumMax);
        }
    }
}
