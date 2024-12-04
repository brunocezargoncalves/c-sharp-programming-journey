using System;

namespace CSharpProgrammingJourney.MethodsAndFunctions
{
    class PassingDelegateAsParameter
    {
        public delegate int Operation(int x, int y);

        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static string Calc(Operation op, int x, int y)
        {
            var result = op(x, y);
            return "Resultado: " + result;
        }

        public static void Execute()
        {
            Operation sub = (int x, int y) => x - y;
            Console.WriteLine(Calc(sub, 3, 2));
            Console.WriteLine(Calc(Sum, 3, 2));
        }
    }
}
