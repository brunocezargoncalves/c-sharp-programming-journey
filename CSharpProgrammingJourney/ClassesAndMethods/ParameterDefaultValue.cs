using System;

namespace CSharpProgrammingJourney.ClassesAndMethods
{
    class ParameterDefaultValue
    {
        public static int Sum(int a = 1, int b = 1)
        {
            return a + b;
        }

        public static void Execute()
        {
            Console.WriteLine(Sum(0));
            Console.WriteLine(Sum(10, 20));
            Console.WriteLine(Sum(50));
            Console.WriteLine(Sum(a: 5, b: 5));
            Console.WriteLine(Sum(b: 15));
        }
    }
}
