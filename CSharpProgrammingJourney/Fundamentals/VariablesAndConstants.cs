using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingJourney.Fundamentals
{
    class VariablesAndConstants
    {
        public static void Execute()
        {
            // Área da circuferência
            double radius = 4.5;

            const double PI = 3.14;

            double area = PI * radius * radius;

            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            // Tipos internos
            bool itsRaining = true;
            byte yearsOld = 36;
            sbyte monthsOld = 12;
            short salary = short.MaxValue;
            int momoryIntValue = int.MaxValue;
            uint polulation = uint.MinValue; // Sem sínal/sem negativo
            long maxLong = long.MaxValue;
            ulong minLong = ulong.MinValue;
            float minFloat = 1299.99F;
            double valueApple = 1_000_000_000_000;
            decimal amountStars = decimal.MaxValue;
            char character = 'B';
            string text = "Bruno";
        }
    }
}