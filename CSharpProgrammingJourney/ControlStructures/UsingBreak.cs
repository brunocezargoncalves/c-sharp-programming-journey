using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingJourney.ControlStructures
{
    class UsingBreak
    {
        public static void Execute()
        {
            Random random = new Random();
            int number = random.Next(1, 51);

            Console.WriteLine("O número que queremos é {0}.", number);

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("{0} é o número que queremos? ", i);

                if (i == number)
                {
                    Console.WriteLine("Sim!");
                    break;
                }
                else
                {
                    Console.WriteLine("Não");
                }                
            }

            Console.WriteLine("Número encontrado!");
        }
    }
}
