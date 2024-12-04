using System;
using System.Collections.Generic;

namespace CSharpProgrammingJourney.OO
{
    // Todos os métodos são públicos e abstratos (não possuem implementação)
    interface BinaryOperation
    {
        int Operation(int a, int b);
    }

    class Sum : BinaryOperation
    {
        public int Operation(int a, int b)
        {
            return a + b;
        }
    }

    class Subtraction : BinaryOperation
    {
        public int Operation(int a, int b)
        {
            return a - b;
        }
    }

    class Calc
    {
        List<BinaryOperation> operations = new List<BinaryOperation>
        {
            new Sum(),
            new Subtraction(),
        };

        public string Execute(int a, int b)
        {
            string result = "";

            foreach (var operation in operations)
            {
                result += $"Usando {operation.GetType().Name} = {operation.Operation(a, b)}\n";
            }

            return result;
        }
    }

    class Interface
    {
        public static void Execute()
        {
            var calc = new Calc();
            var result = calc.Execute(20, 5);

            Console.WriteLine(result);
        }
    }
}
