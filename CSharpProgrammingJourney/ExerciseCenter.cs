using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpProgrammingJourney
{
    public class ExerciseCenter
    {
        Dictionary<string, Action> Exercises;

        public ExerciseCenter(Dictionary<string, Action> exercises)
        {
            Exercises = exercises;
        }

        public void SelectAndRun()
        {
            int i = 1;

            foreach (var exercises in Exercises)
            {
                Console.WriteLine("{0}) {1}", i, exercises.Key);
                i++;
            }

            Console.Write("Digite o número (ou vazio para o último)? ");

            int.TryParse(Console.ReadLine(), out int num);
            bool numValido = num > 0 && num <= Exercises.Count;
            num = numValido ? num - 1 : Exercises.Count - 1;

            string nomeDoExercicio = Exercises.ElementAt(num).Key;

            Console.Write("\nExecutando exercício ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(nomeDoExercicio);
            Console.ResetColor();

            Console.WriteLine(String.Concat(
                Enumerable.Repeat("=", nomeDoExercicio.Length + 21)) + "\n");

            Action executar = Exercises.ElementAt(num).Value;
            try
            {
                executar();
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ocorreu um erro: {0}", e.Message);
                Console.ResetColor();

                Console.WriteLine(e.StackTrace);
            }
        }
    }
}