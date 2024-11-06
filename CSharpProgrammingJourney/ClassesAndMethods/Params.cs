using System;

namespace CSharpProgrammingJourney.ClassesAndMethods
{
    class Params
    {
        // params recebe um conjunto de parâmetro agrupados
        public static void Welcome(params string[] names)
        {
            foreach (string name in names) {
                Console.WriteLine("Olá, {0}! ", name);
            }
        }

        public static void Execute()
        {
            Params.Welcome("Bruno", "Amanda", "Arthur", "Aurora");
        }
    }
}
