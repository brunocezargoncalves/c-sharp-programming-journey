using System;
using System.Globalization;

namespace CSharpProgrammingJourney.Fundamentals
{
    class FormattingNumbers
    {
        public static void Execute()
        {
            double valueNumber = 15.175;

            // Uma casa decimal 
            Console.WriteLine(valueNumber.ToString("F1"));

            // Duas casas decimais
            Console.WriteLine(valueNumber.ToString("F2"));
            Console.WriteLine(valueNumber.ToString("#.##"));

            // Formatando para moeda
            Console.WriteLine(valueNumber.ToString("C"));

            // Percentual
            Console.WriteLine(valueNumber.ToString("P"));

            // Alterando a configuração por país
            CultureInfo culture = new CultureInfo("en-US");
            Console.WriteLine(valueNumber.ToString("C3", culture));

            // Completar com zeros a direira com o número de posições
            int intNumber = 256;
            Console.WriteLine(intNumber.ToString("D10"));
        }
    }
}
