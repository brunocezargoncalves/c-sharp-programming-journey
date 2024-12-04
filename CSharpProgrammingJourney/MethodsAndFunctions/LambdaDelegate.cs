using System;

namespace CSharpProgrammingJourney.MethodsAndFunctions
{
    // É um tipo que define a assinatura de uma função
    delegate double Operation(double x, double y);

    class LambdaDelegate
    {
        public static void Execute()
        {
            Operation sum = (x, y) => x + y;
            Operation sub = (x, y) => x - y;
            Operation mult = (x, y) => x * y;

            Console.WriteLine(sum(3, 3));
            Console.WriteLine(sub(5, 2));
            Console.WriteLine(mult(12, 8));
        }
    }
}
