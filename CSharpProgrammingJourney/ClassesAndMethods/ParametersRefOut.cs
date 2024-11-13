using System;

namespace CSharpProgrammingJourney.ClassesAndMethods
{
    class ParametersRefOut
    {
        public static void AlterRef(ref int number)
        {
            number = number + 1000;
        }

        public static void AlterOut(out int number)
        {
            number = 0;
            number = number + 15;
        }

        public static void Execute()
        {
            int a = 3;
            AlterRef(ref a);
            Console.WriteLine(a);

            // Pode, inclusive, simular o retorno de multiplos valores
            AlterOut(out int b);
            Console.WriteLine(b);
        }
    }
}
