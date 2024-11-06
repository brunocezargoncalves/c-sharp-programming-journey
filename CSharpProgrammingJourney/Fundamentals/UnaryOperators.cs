using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingJourney.Fundamentals
{
    class UnaryOperators
    {
        public static void Execute()
        {
            var negativeValue = -5;
            var number1 = 2;
            var number2 = 3;
            var boolean = true;

            Console.WriteLine(-negativeValue); // Inverte o sinal
            Console.WriteLine(!boolean); // Negação lógica

            number1++; // Incremento (com sinal pós-fixado)
            Console.WriteLine(number2);

            --number2; // Decremento (com sinal pré-fixado - com mais precedência)
            Console.WriteLine(number2);

            // O decremento acontece antes por que o sinal -- está pré-fixado
            Console.WriteLine(number1++ == --number2);
            Console.WriteLine($"{number1} {number2}");
        }
    }
}
