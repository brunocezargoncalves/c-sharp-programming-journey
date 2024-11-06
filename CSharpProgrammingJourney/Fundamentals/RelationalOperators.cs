using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingJourney.Fundamentals
{
    class RelationalOperators
    {
        public static void Execute()
        {
            double studentGrade = 6.0;
            double averageGrade = 7.0;

            Console.WriteLine("Nota invália? {0}", studentGrade > 10.0);
            Console.WriteLine("Nota invália? {0}", studentGrade < 0.0);
            Console.WriteLine("Nota invália? {0}", studentGrade == 0.0);
            Console.WriteLine("Têm como melhorar? {0}", studentGrade != 10.0);
            Console.WriteLine("Passou por média? {0}", studentGrade >= averageGrade);
            Console.WriteLine("Recuperação? {0}", studentGrade < averageGrade && studentGrade >= 3.0);
            Console.WriteLine("Reprovado? {0}", studentGrade <= 3.0);
        }
    }
}
