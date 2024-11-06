using System;

namespace CSharpProgrammingJourney.ControlStructures
{
    class StructureDoWhile
    {
        public static void Execute()
        {
            var input = string.Empty;

            // Melhor para repetições indeterminadas com pelo menos uma execução
            do
            {
                Console.Write("Digite o nome do aluno: ");
                input = Console.ReadLine();

                Console.WriteLine("Bem-vindo, {0}!", input);
                Console.Write("Outro aluno (S/N)?");
                input = Console.ReadLine();

            } while (input.ToLower() == "s");
        }
    }
}
