using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingJourney.Fundamentals
{
    class LogicalOperators
    {
        public static void Execute()
        {
            var performedFirstWork = true;
            Console.WriteLine("Realizou o primeiro trabalho? {0}", performedFirstWork);

            var performedSecondJob = false;
            Console.WriteLine("Realizou o segundo trabalho? {0}", performedSecondJob);

            // E
            var buyTV50 = performedFirstWork && performedSecondJob;
            Console.WriteLine("Comprou a TV de 50'? {0}", buyTV50);

            // OU
            var buyIceCream = performedFirstWork || performedSecondJob;
            Console.WriteLine("Tomou sorvete? {0}", buyIceCream);

            // XOR (ou exclusivo)
            var buyTV32 = performedFirstWork ^ performedSecondJob;
            Console.WriteLine("Comprou a TV de 32'? {0}", buyTV32);

            // Negação lógica (operador unário)
            Console.WriteLine("Ficou mais saudável? {0}", !buyIceCream);
        }
    }
}
