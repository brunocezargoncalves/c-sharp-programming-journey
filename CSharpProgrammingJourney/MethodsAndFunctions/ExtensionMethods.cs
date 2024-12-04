using System;

namespace CSharpProgrammingJourney.MethodsAndFunctions
{
    public static class IntExtension
    {
        public static int Sum(this int num, int otherNum)
        {
            return num + otherNum;
        }

        public static int Sub(this int num, int otherNum)
        {
            return num - otherNum;
        }
    }

    public class ExtensionMethods
    {
        public static void Execute()
        {
            int num = 5;

            Console.WriteLine(num.Sum(3));
            Console.WriteLine(num.Sub(10));

            Console.WriteLine(2.Sum(3));
            Console.WriteLine(2.Sub(4));
        }
    }
}
