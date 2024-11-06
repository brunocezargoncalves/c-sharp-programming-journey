using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingJourney.Fundamentals
{
    class TernaryOperator
    {
        public static void Execute()
        {
            var grade = 2.9;
            var result = grade >= 7.0 ? "passou!" : grade < 7.0 && grade > 3.0 ? "está em recuperação!" : "está reprovado!";

            Console.WriteLine("O aluno tirou a nota {0} e {1}", grade, result);
        }
    }
}
