using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpProgrammingJourney.Fundamentals
{
    class ReadingData
    {
        public static void Execute()
        {
            Console.WriteLine("Qual é o seu nome? ");
            string name = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade? ");
            int.TryParse(Console.ReadLine(), out int age);

            Console.WriteLine("Qual é o seu salário? ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
    }
}
