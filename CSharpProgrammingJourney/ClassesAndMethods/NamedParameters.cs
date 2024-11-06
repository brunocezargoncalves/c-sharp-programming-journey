using System;

namespace CSharpProgrammingJourney.ClassesAndMethods
{
    class NamedParameters
    {
        public static void Format(int day, int mouth, int year)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", day, mouth, year);
        }

        public static void Execute()
        {
            Format(mouth: 7, day: 22, year: 1988);
        }
    }
}
