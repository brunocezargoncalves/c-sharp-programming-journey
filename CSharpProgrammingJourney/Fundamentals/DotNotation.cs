using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingJourney.Fundamentals
{
    class DotNotation
    {
        public static void Execute()
        {
            var greeting = "Olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
            Console.WriteLine(greeting);

            // O ? só permite que o valor seja acessado caso ele não seja vázio
            string valueImportant = null;
            Console.WriteLine($"{valueImportant?.Length}");
        }
    }
}
