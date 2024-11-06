using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingJourney.Fundamentals
{
    class AssignmentOperators
    {
        public static void Execute()
        {            
            var num1 = 3; // Operação atribuitiva
            num1 = 7; // Operação substituitiva
            num1 += 10; // Operação aditiva
            num1 -= 3; // Operação subtrativa
            num1 *= 5; // Operação multiplicativa
            num1 /= 2; // Operação divisiva

            Console.WriteLine(num1);

            // Atribuição por cópia de valor (também existe por referência)
            int a = 1;
            int b = a;

            // Operadores unários
            a++; // Incremento
            b++; // Decremento
        }
    }
}
