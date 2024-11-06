using System;

namespace CSharpProgrammingJourney.ControlStructures
{
    class StructureForEach
    {
        public static void Execute()
        {
            var word = "Opa!";

            // Melhor para percorrer conjuntos de dados
            foreach (var letter in word)
            {
                Console.WriteLine(letter);
            }

            var studants = new string[] { "Bruno", "João", "Maria" };

            foreach (string studant in studants)
            {
                Console.WriteLine(studant);
            }
        }
    }
}
