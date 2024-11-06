using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingJourney.ControlStructures
{
    class UsingContinue
    {
        public static void Execute()
        {
            int interval = 100;
            int amount = 0;

            Console.WriteLine("Números pares entre 1 e {0}!", interval);

            for (int i = 0; i <= interval; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                else
                {
                    amount++;
                }

            }

            Console.WriteLine("Existem {0} números pares entre 1 e {1}!", amount, interval);
        }
    }
}
