using System;

namespace CSharpProgrammingJourney.ControlStructures
{
    class StructureIfElseIf
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
                Console.WriteLine("Aprovado com quadro de honra!");
            else if (grade > 7.0)
                Console.WriteLine("Aprovado!");
            else if (grade < 7.0 && grade >= 5.0)
                Console.WriteLine("Recuperação!");
            else if ((grade < 5.0 && grade > 3.0) && goodBehavior)
                Console.WriteLine("Recuperação por bom comportamento!");
            else if (grade < 4.0)
                Console.WriteLine("Reprovado!");
            else
                Console.WriteLine("Nota inválida!");
        }
    }
}
