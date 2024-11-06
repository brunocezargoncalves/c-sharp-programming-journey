using System;

namespace CSharpProgrammingJourney.ControlStructures
{
    class StructureIf
    {
        public static void Execute()
        {
            bool goodBehavior = false;
            string inputValue;

            Console.Write("Digite a nota do aluno: ");
            inputValue = Console.ReadLine();
            Double.TryParse(inputValue, out double grade);

            Console.Write("Possui bom comportamento (S/N): ");
            inputValue = Console.ReadLine();

            goodBehavior = inputValue.ToUpper() == "S";

            if (grade >= 9.0 && goodBehavior)
                Console.WriteLine("Quadro de honra!");
        }
    }
}
