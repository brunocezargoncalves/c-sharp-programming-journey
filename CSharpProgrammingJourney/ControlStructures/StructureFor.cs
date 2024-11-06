using System;

namespace CSharpProgrammingJourney.ControlStructures
{
    class StructureFor
    {
        public static void Execute()
        {
            // Melhor para repetições determinadas
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Contando até 10: {0}", i);
            }
        }
    }
}
