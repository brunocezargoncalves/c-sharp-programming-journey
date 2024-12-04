using System;

namespace CSharpProgrammingJourney.MethodsAndFunctions
{
    class UsingDelegate
    {
        delegate double Sum(double a, double b);
        delegate void PrintSum(double a, double b);

        static double MySum(double x, double y)
        {
            return x + y;
        }

        static void MyPrintSum(double x, double y)
        {
            Console.WriteLine(x + y);
        }

        public static void Execute()
        {
            // Podemos associar (armazenar) um delegate a uma função pré-existente desde que haja compatibilidade entre as assinaturas
            Sum op1 = MySum;
            Console.WriteLine(op1(2, 3));

            PrintSum op2 = MyPrintSum;
            op2(5.4, 8);

            Func<double, double, double> op3 = MySum;
            Console.WriteLine(op3(2.5, 3));

            Action<double, double> op4 = MyPrintSum;
            op4(7.7, 23.4);
        }
    }
}
