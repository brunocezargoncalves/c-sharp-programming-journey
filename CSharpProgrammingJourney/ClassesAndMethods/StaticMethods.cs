using System;

namespace CSharpProgrammingJourney.ClassesAndMethods
{
    // Métodos estáticos não pertencem ao objeto (a instância da classe) e sim a classe
    class StaticCalculator
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static int Subtraction(int x, int y)
        {
            return x - y;
        }

        public static int Multiplication(int x, int y)
        {
            return x * y;
        }

        public static int Division(int x, int y)
        {
            return x / y;
        }
    }

    class StaticMethods
    {
        public static void Execute()
        {
            var result = StaticCalculator.Sum(10, 10);
            Console.WriteLine(result);

            Console.WriteLine(StaticCalculator.Multiplication(10, 10));
        }
    }
}
