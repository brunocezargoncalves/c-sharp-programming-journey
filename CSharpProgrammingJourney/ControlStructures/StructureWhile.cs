using System;

namespace CSharpProgrammingJourney.ControlStructures
{
    class StructureWhile
    {
        public static void Execute()
        {
            int guess = 0;
            Random random = new Random();

            int secretNumber = random.Next(1, 16);
            bool hit = false;
            int attempt = 0;

            // Melhor para repetições indeterminadas com 0 ou N execuções
            while (!hit && attempt < 5)
            {
                attempt++;
                Console.WriteLine("Tentativa {0} de 5", attempt);

                Console.Write("Qual o número secreto? ");
                int.TryParse(Console.ReadLine(), out guess);

                hit = guess == secretNumber ? true : false;

                if (hit)
                {
                    Console.WriteLine("Acertou!");
                    Console.WriteLine("O número secreto é {0}!", secretNumber);
                }
                else if (!hit && attempt == 5)
                {
                    Console.WriteLine("Errou!");
                    Console.WriteLine("Acabaram suas tentativas!");
                }
                else
                {
                    if (guess > secretNumber)
                        Console.WriteLine("Dica: o número secreto é MENOR que {0}...", guess);
                    else
                        Console.WriteLine("Dica: o número secreto é MAIOR que {0}...", guess);
                }
            }

            Console.WriteLine("Fim do jogo!");
        }
    }
}
